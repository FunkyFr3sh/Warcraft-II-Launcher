using System;
using System.Collections.Generic;
//using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Threading;
using System.Globalization;
using System.Text;


namespace War2Launcher
{
    static class Program
    {
        public static readonly string PATH = 
            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + Path.DirectorySeparatorChar;

        public static string LogFile = Path.ChangeExtension(Application.ExecutablePath, ".log");
        public static Translation Translation;
        public static bool RunsOnWine = false;

        static string PermissionError = 
                "Please check your permissions, Anti-Virus and Firewall settings!" + Environment.NewLine +
                "Would you like to restart the program with administrator rights to avoid errors?";

        static string AccessDeniedCaption = "Error: Access denied";

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.UnhandledException += 
                new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            LoadTranslation();

            if (!GotWritePermissions())
            {
                if (MessageBox.Show(
                    Translation.GetString(PermissionError), 
                    Translation.GetString(AccessDeniedCaption), 
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        RunAsAdmin(Application.ExecutablePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                return;
            }

            try
            {
                RunsOnWine = 
                    NativeMethods.GetProcAddress(
                        NativeMethods.GetModuleHandle("kernel32"), "wine_get_unix_file_name") != (IntPtr)0;
            }
            catch { }

            Application.Run(new War2Launcher());

            if (Debugger.IsAttached)
                Translation.Save();
        }

        static void LoadTranslation()
        {
            if (Debugger.IsAttached)
                Translation = new Translation("TranslationEN.txt");
            else
                Translation = new Translation(Path.ChangeExtension(Application.ExecutablePath, ".txt"));

            try
            {
                string culture = Thread.CurrentThread.CurrentCulture.ToString().Split('-')[0];
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

                //load the english one to have everything in the correct order (new strings at the end of the file)
                Translation.Load(Properties.Resources.TranslationEN);

                //Only load translation if there was no custom one found in the folder
                if (!Debugger.IsAttached && !Translation.Load()) 
                {
                    switch (culture)
                    {
                        case "ru": Translation.Load(Properties.Resources.TranslationRU); break;
                        //case "es": Translation.Load(Properties.Resources.TranslationES); break;
                        case "de": Translation.Load(Properties.Resources.TranslationDE); break;
                        //case "zh": Translation.Load(Properties.Resources.TranslationZH); break;
                        //case "pt": Translation.Load(Properties.Resources.TranslationPT); break;
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLogfile(ex);
                MessageBox.Show(ex.Message);
            }
            
        }
        static bool GotWritePermissions()
        {
            try
            {
                File.WriteAllText(Path.Combine(PATH, "WritePermissionTestFile.txt"), "Test");
                File.Delete(Path.Combine(PATH, "WritePermissionTestFile.txt"));
            }
            catch
            {
                return false;
            }
            return true;
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            WriteLogfile(e.Exception);
            MessageBox.Show(e.Exception.Message);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;
            WriteLogfile(ex);
            MessageBox.Show(ex.Message);
        }

        public static void RunAsAdmin(string fileName, string args = null)
        {
            var psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.WorkingDirectory = Path.GetDirectoryName(fileName);
            psi.FileName = fileName;
            if (args != null && args.Length > 0)
                psi.Arguments = args;
            psi.Verb = "runas";
            Process.Start(psi);
        }

        public static void WriteLogfile(Exception ex, params string[] additionalInfo)
        {
            try
            {
                using (var sw = new StreamWriter(LogFile, true))
                {
                    sw.WriteLine(DateTime.Now.ToString());
                    foreach (string line in additionalInfo)
                        sw.WriteLine(line);

                    sw.WriteLine(ex.ToString());
                    sw.WriteLine("");
                }
            }
            catch { }
        }
    }
}
