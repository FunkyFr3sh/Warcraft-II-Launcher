using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Globalization;
//1.3.1
namespace War2Launcher
{
    class Translation
    {
        const string NEW_LINE = "#+";

        Dictionary<string, string> StringTable = new Dictionary<string, string>();
        object _lock = new object();
        string StringTablePath;

        public Translation(string stringTablePath)
        {
            StringTablePath = stringTablePath;
        }

        public bool Load()
        {
            lock (_lock)
            {
                try
                {
                    using (var fileStream = new FileStream(StringTablePath, FileMode.Open, FileAccess.Read))
                        Load(fileStream);
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }

        public void Load(byte[] bytes)
        {
            lock (_lock)
            {
                using (var memoryStream = new MemoryStream(bytes))
                    Load(memoryStream);
            }
        }

            public void Load(Stream stream)
        {
            lock (_lock)
            {
                using (var streamReader = new StreamReader(stream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (line.StartsWith(";") || !line.Contains("="))
                            continue;

                        string key = line.Remove(line.IndexOf("="));
                        string value = line.Substring(line.IndexOf("=") + 1);

                        if (key.Length == 0)
                        {
                            using (var md5 = MD5CryptoServiceProvider.Create())
                            {
                                byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(value));
                                key = BitConverter.ToString(hash).Replace("-", "").ToLower().Remove(8);
                            }
                        }

                        if (key.Length == 8)
                            StringTable[key] = value.Replace(NEW_LINE, Environment.NewLine);
                    }
                }
            }
        }

        public void Save(string filePath = null)
        {
            lock (_lock)
            {
                using (var sw = new StreamWriter(filePath == null ? StringTablePath : filePath, false, Encoding.UTF8))
                {
                    foreach (var pair in StringTable)
                        sw.WriteLine(
                            string.Format("{0}={1}", pair.Key, pair.Value.Replace(Environment.NewLine, NEW_LINE)));
                }
            }
        }

        public string GetString(string text)
        {
            lock (_lock)
            {
                if (text != null && text.Length > 0)
                {
                    string key;
                    using (var md5 = MD5CryptoServiceProvider.Create())
                    {
                        byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(text.Replace(Environment.NewLine, NEW_LINE)));
                        key = BitConverter.ToString(hash).Replace("-", "").ToLower().Remove(8);
                    }
                    
                    if (StringTable.ContainsKey(key))
                        return StringTable[key];
                    else
                        StringTable.Add(key, text);
                }

                return text;
            }
        }

        public void ApplyTo(ref string text)
        {
            lock (_lock)
            {
                text = GetString(text);
            }
        }

        public void ApplyTo(Form form, ToolTip toolTip = null)
        {
            lock (_lock)
            {
                form.Text = GetString(form.Text);
                ApplyTo(form.Controls, toolTip);
            }
        }

        public void ApplyTo(Control.ControlCollection controls, ToolTip toolTip = null)
        {
            lock (_lock)
            {
                foreach (Control control in controls)
                {
                    ApplyTo(control, toolTip);

                    if (control.HasChildren)
                        ApplyTo(control.Controls, toolTip);
                }
            }
        }

        public void ApplyTo(Control control, ToolTip toolTip = null)
        {
            lock (_lock)
            {
                if (control is ComboBox)
                {
                    var combobox = (ComboBox)control;

                    for (int i = 0; i < combobox.Items.Count; i++)
                    {
                        if (combobox.Items[i] is string)
                            combobox.Items[i] = GetString((string)combobox.Items[i]);
                    }
                }
                if (control is DataGridView)
                {
                    var dataGrid = (DataGridView)control;

                    foreach (DataGridViewColumn column in dataGrid.Columns)
                        column.HeaderCell.Value = GetString(column.HeaderCell.Value.ToString());

                    foreach (DataGridViewRow row in dataGrid.Rows)
                        row.HeaderCell.Value = GetString(row.HeaderCell.Value.ToString());
                }
                else
                    control.Text = GetString(control.Text);

                if (toolTip != null)
                    toolTip.SetToolTip(control, GetString(toolTip.GetToolTip(control)));
            }
        }

    }
}
