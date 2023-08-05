using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace War2Launcher
{
    public partial class War2Launcher : Form
    {
        public War2Launcher()
        {
            InitializeComponent();
            Program.Translation.ApplyTo(this);
        }
        public void CheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            var checkBox = ((CheckBox)sender);

            if (checkBox.Checked) checkBox.Image = Properties.Resources.checkbox_pressed_selected;  //TickButtonBitmap;
            else checkBox.Image = Properties.Resources.checkbox_normal_unselected;  //MinusButtonBitmap;
        }
        public void CheckBox_MouseDown(object sender, EventArgs e)
        {
            var checkBox = ((CheckBox)sender);

            if (checkBox.Checked) checkBox.Image = Properties.Resources.checkbox_pressed_selected;  //TickButtonBitmap;
            else checkBox.Image = Properties.Resources.checkbox_normal_unselected;  //MinusButtonBitmap;
        }
        public void RadioButton_CheckStateChanged(object sender, EventArgs e)
        {
            var radioButton = ((RadioButton)sender);

            if (radioButton.Checked) radioButton.Image = Properties.Resources.radio_normal_selected;  //TickButtonBitmap;
            else radioButton.Image = Properties.Resources.radio_normal_unselected;  //MinusButtonBitmap;
        }
        public void CheckBox_MouseEnter(object sender, EventArgs e)
        {
            ((CheckBox)sender).ForeColor = System.Drawing.Color.Red;
        }
        public void CheckBox_MouseLeave(object sender, EventArgs e)
        {
            ((CheckBox)sender).ForeColor = System.Drawing.Color.Black;
        }
        public void RadioButton_MouseEnter(object sender, EventArgs e)
        {
            ((RadioButton)sender).ForeColor = System.Drawing.Color.Red;
        }
        public void RadioButton_MouseLeave(object sender, EventArgs e)
        {
            ((RadioButton)sender).ForeColor = System.Drawing.Color.Black;
        }
    }

}
