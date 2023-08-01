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
    }
}
