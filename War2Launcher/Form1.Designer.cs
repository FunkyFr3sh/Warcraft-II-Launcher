namespace War2Launcher
{
    partial class War2Launcher
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(War2Launcher));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPlay = new System.Windows.Forms.TabPage();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBoxWar2HD = new System.Windows.Forms.GroupBox();
            this.radioButtonOriginal1 = new System.Windows.Forms.RadioButton();
            this.radioButtonWideScreen = new System.Windows.Forms.RadioButton();
            this.radioButtonOriginal = new System.Windows.Forms.RadioButton();
            this.buttonPlayWar2 = new System.Windows.Forms.Button();
            this.tabPlugins = new System.Windows.Forms.TabPage();
            this.tabInterfaceOptions = new System.Windows.Forms.TabPage();
            this.tabConnection = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPlay.SuspendLayout();
            this.groupBoxWar2HD.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPlay);
            this.tabControl1.Controls.Add(this.tabPlugins);
            this.tabControl1.Controls.Add(this.tabInterfaceOptions);
            this.tabControl1.Controls.Add(this.tabConnection);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPlay
            // 
            this.tabPlay.Controls.Add(this.checkBox3);
            this.tabPlay.Controls.Add(this.checkBox2);
            this.tabPlay.Controls.Add(this.checkBox1);
            this.tabPlay.Controls.Add(this.groupBoxWar2HD);
            this.tabPlay.Controls.Add(this.buttonPlayWar2);
            this.tabPlay.Location = new System.Drawing.Point(4, 22);
            this.tabPlay.Name = "tabPlay";
            this.tabPlay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlay.Size = new System.Drawing.Size(768, 400);
            this.tabPlay.TabIndex = 0;
            this.tabPlay.Text = "Play";
            this.tabPlay.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox3.FlatAppearance.BorderSize = 0;
            this.checkBox3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.checkBox3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkBox3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.ForeColor = System.Drawing.Color.Black;
            this.checkBox3.Image = ((System.Drawing.Image)(resources.GetObject("checkBox3.Image")));
            this.checkBox3.Location = new System.Drawing.Point(80, 146);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(88, 23);
            this.checkBox3.TabIndex = 69;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckStateChanged += new System.EventHandler(this.CheckBox_CheckStateChanged);
            this.checkBox3.MouseEnter += new System.EventHandler(this.CheckBox_MouseEnter);
            this.checkBox3.MouseLeave += new System.EventHandler(this.CheckBox_MouseLeave);
//            this.checkBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckBox_MouseDown);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(120, 189);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 68;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.checkBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Image = ((System.Drawing.Image)(resources.GetObject("checkBox1.Image")));
            this.checkBox1.Location = new System.Drawing.Point(80, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 23);
            this.checkBox1.TabIndex = 67;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.CheckBox_CheckStateChanged);
            this.checkBox1.MouseEnter += new System.EventHandler(this.CheckBox_MouseEnter);
            this.checkBox1.MouseLeave += new System.EventHandler(this.CheckBox_MouseLeave);
            // 
            // groupBoxWar2HD
            // 
            this.groupBoxWar2HD.Controls.Add(this.radioButtonOriginal1);
            this.groupBoxWar2HD.Controls.Add(this.radioButtonWideScreen);
            this.groupBoxWar2HD.Controls.Add(this.radioButtonOriginal);
            this.groupBoxWar2HD.Location = new System.Drawing.Point(6, 6);
            this.groupBoxWar2HD.Name = "groupBoxWar2HD";
            this.groupBoxWar2HD.Size = new System.Drawing.Size(200, 105);
            this.groupBoxWar2HD.TabIndex = 1;
            this.groupBoxWar2HD.TabStop = false;
            this.groupBoxWar2HD.Text = "Warcraft II HD";
            // 
            // radioButtonOriginal1
            // 
            this.radioButtonOriginal1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonOriginal1.AutoSize = true;
            this.radioButtonOriginal1.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonOriginal1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonOriginal1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonOriginal1.FlatAppearance.BorderSize = 0;
            this.radioButtonOriginal1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.radioButtonOriginal1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radioButtonOriginal1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radioButtonOriginal1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonOriginal1.ForeColor = System.Drawing.Color.Black;
            this.radioButtonOriginal1.Image = global::War2Launcher.Properties.Resources.radio_normal_unselected;
            this.radioButtonOriginal1.Location = new System.Drawing.Point(-5, 71);
            this.radioButtonOriginal1.Name = "radioButtonOriginal1";
            this.radioButtonOriginal1.Size = new System.Drawing.Size(77, 25);
            this.radioButtonOriginal1.TabIndex = 2;
            this.radioButtonOriginal1.TabStop = true;
            this.radioButtonOriginal1.Text = "Original1";
            this.radioButtonOriginal1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonOriginal1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButtonOriginal1.UseVisualStyleBackColor = false;
            this.radioButtonOriginal1.CheckedChanged += new System.EventHandler(this.RadioButton_CheckStateChanged);
            this.radioButtonOriginal1.MouseEnter += new System.EventHandler(this.RadioButton_MouseEnter);
            this.radioButtonOriginal1.MouseLeave += new System.EventHandler(this.RadioButton_MouseLeave);
            // 
            // radioButtonWideScreen
            // 
            this.radioButtonWideScreen.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonWideScreen.AutoSize = true;
            this.radioButtonWideScreen.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonWideScreen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonWideScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonWideScreen.FlatAppearance.BorderSize = 0;
            this.radioButtonWideScreen.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.radioButtonWideScreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radioButtonWideScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radioButtonWideScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonWideScreen.ForeColor = System.Drawing.Color.Black;
            this.radioButtonWideScreen.Image = global::War2Launcher.Properties.Resources.radio_normal_unselected;
            this.radioButtonWideScreen.Location = new System.Drawing.Point(-5, 42);
            this.radioButtonWideScreen.Name = "radioButtonWideScreen";
            this.radioButtonWideScreen.Size = new System.Drawing.Size(98, 25);
            this.radioButtonWideScreen.TabIndex = 1;
            this.radioButtonWideScreen.Text = "Wide Screen";
            this.radioButtonWideScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonWideScreen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButtonWideScreen.UseVisualStyleBackColor = false;
            this.radioButtonWideScreen.CheckedChanged += new System.EventHandler(this.RadioButton_CheckStateChanged);
            this.radioButtonWideScreen.MouseEnter += new System.EventHandler(this.RadioButton_MouseEnter);
            this.radioButtonWideScreen.MouseLeave += new System.EventHandler(this.RadioButton_MouseLeave);
            // 
            // radioButtonOriginal
            // 
            this.radioButtonOriginal.AutoSize = true;
            this.radioButtonOriginal.Location = new System.Drawing.Point(6, 19);
            this.radioButtonOriginal.Name = "radioButtonOriginal";
            this.radioButtonOriginal.Size = new System.Drawing.Size(60, 17);
            this.radioButtonOriginal.TabIndex = 0;
            this.radioButtonOriginal.Text = "Original";
            this.radioButtonOriginal.UseVisualStyleBackColor = true;
            // 
            // buttonPlayWar2
            // 
            this.buttonPlayWar2.Location = new System.Drawing.Point(50, 281);
            this.buttonPlayWar2.Name = "buttonPlayWar2";
            this.buttonPlayWar2.Size = new System.Drawing.Size(179, 71);
            this.buttonPlayWar2.TabIndex = 0;
            this.buttonPlayWar2.Text = "Play Warcraft II";
            this.buttonPlayWar2.UseVisualStyleBackColor = true;
            // 
            // tabPlugins
            // 
            this.tabPlugins.Location = new System.Drawing.Point(4, 22);
            this.tabPlugins.Name = "tabPlugins";
            this.tabPlugins.Size = new System.Drawing.Size(768, 400);
            this.tabPlugins.TabIndex = 2;
            this.tabPlugins.Text = "Plugins";
            this.tabPlugins.UseVisualStyleBackColor = true;
            // 
            // tabInterfaceOptions
            // 
            this.tabInterfaceOptions.Location = new System.Drawing.Point(4, 22);
            this.tabInterfaceOptions.Name = "tabInterfaceOptions";
            this.tabInterfaceOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabInterfaceOptions.Size = new System.Drawing.Size(768, 400);
            this.tabInterfaceOptions.TabIndex = 1;
            this.tabInterfaceOptions.Text = "Interface Options";
            this.tabInterfaceOptions.UseVisualStyleBackColor = true;
            // 
            // tabConnection
            // 
            this.tabConnection.Location = new System.Drawing.Point(4, 22);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.Size = new System.Drawing.Size(768, 400);
            this.tabConnection.TabIndex = 3;
            this.tabConnection.Text = "Connection";
            this.tabConnection.UseVisualStyleBackColor = true;
            // 
            // War2Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "War2Launcher";
            this.Text = "Warcraft II Launcher";
            this.tabControl1.ResumeLayout(false);
            this.tabPlay.ResumeLayout(false);
            this.tabPlay.PerformLayout();
            this.groupBoxWar2HD.ResumeLayout(false);
            this.groupBoxWar2HD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPlay;
        private System.Windows.Forms.TabPage tabInterfaceOptions;
        private System.Windows.Forms.TabPage tabPlugins;
        private System.Windows.Forms.TabPage tabConnection;
        private System.Windows.Forms.Button buttonPlayWar2;
        private System.Windows.Forms.GroupBox groupBoxWar2HD;
        private System.Windows.Forms.RadioButton radioButtonWideScreen;
        private System.Windows.Forms.RadioButton radioButtonOriginal;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RadioButton radioButtonOriginal1;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

