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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPlay = new System.Windows.Forms.TabPage();
            this.tabInterfaceOptions = new System.Windows.Forms.TabPage();
            this.tabPlugins = new System.Windows.Forms.TabPage();
            this.tabConnection = new System.Windows.Forms.TabPage();
            this.buttonPlayWar2 = new System.Windows.Forms.Button();
            this.groupBoxWar2HD = new System.Windows.Forms.GroupBox();
            this.radioButtonOriginal = new System.Windows.Forms.RadioButton();
            this.radioButtonWideScreen = new System.Windows.Forms.RadioButton();
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
            // tabPlugins
            // 
            this.tabPlugins.Location = new System.Drawing.Point(4, 22);
            this.tabPlugins.Name = "tabPlugins";
            this.tabPlugins.Size = new System.Drawing.Size(768, 400);
            this.tabPlugins.TabIndex = 2;
            this.tabPlugins.Text = "Plugins";
            this.tabPlugins.UseVisualStyleBackColor = true;
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
            // buttonPlayWar2
            // 
            this.buttonPlayWar2.Location = new System.Drawing.Point(50, 281);
            this.buttonPlayWar2.Name = "buttonPlayWar2";
            this.buttonPlayWar2.Size = new System.Drawing.Size(179, 71);
            this.buttonPlayWar2.TabIndex = 0;
            this.buttonPlayWar2.Text = "Play Warcraft II";
            this.buttonPlayWar2.UseVisualStyleBackColor = true;
            // 
            // groupBoxWar2HD
            // 
            this.groupBoxWar2HD.Controls.Add(this.radioButtonWideScreen);
            this.groupBoxWar2HD.Controls.Add(this.radioButtonOriginal);
            this.groupBoxWar2HD.Location = new System.Drawing.Point(6, 6);
            this.groupBoxWar2HD.Name = "groupBoxWar2HD";
            this.groupBoxWar2HD.Size = new System.Drawing.Size(200, 76);
            this.groupBoxWar2HD.TabIndex = 1;
            this.groupBoxWar2HD.TabStop = false;
            this.groupBoxWar2HD.Text = "Warcraft II HD";
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
            // radioButtonWideScreen
            // 
            this.radioButtonWideScreen.AutoSize = true;
            this.radioButtonWideScreen.Location = new System.Drawing.Point(6, 42);
            this.radioButtonWideScreen.Name = "radioButtonWideScreen";
            this.radioButtonWideScreen.Size = new System.Drawing.Size(87, 17);
            this.radioButtonWideScreen.TabIndex = 1;
            this.radioButtonWideScreen.TabStop = true;
            this.radioButtonWideScreen.Text = "Wide Screen";
            this.radioButtonWideScreen.UseVisualStyleBackColor = true;
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
    }
}

