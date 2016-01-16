namespace PikabuInvaders
{
    partial class settingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hiddenStartBox = new System.Windows.Forms.CheckBox();
            this.autoAttackBox = new System.Windows.Forms.CheckBox();
            this.startupBox = new System.Windows.Forms.CheckBox();
            this.sendStatisticsBox = new System.Windows.Forms.CheckBox();
            this.saveCredentialsBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // hiddenStartBox
            // 
            this.hiddenStartBox.AutoSize = true;
            this.hiddenStartBox.Enabled = false;
            this.hiddenStartBox.Location = new System.Drawing.Point(12, 35);
            this.hiddenStartBox.Name = "hiddenStartBox";
            this.hiddenStartBox.Size = new System.Drawing.Size(114, 17);
            this.hiddenStartBox.TabIndex = 2;
            this.hiddenStartBox.Text = "Запускать в трее";
            this.hiddenStartBox.UseVisualStyleBackColor = true;
            this.hiddenStartBox.CheckedChanged += new System.EventHandler(this.hiddenStartBox_CheckedChanged);
            // 
            // autoAttackBox
            // 
            this.autoAttackBox.AutoSize = true;
            this.autoAttackBox.Location = new System.Drawing.Point(12, 58);
            this.autoAttackBox.Name = "autoAttackBox";
            this.autoAttackBox.Size = new System.Drawing.Size(78, 17);
            this.autoAttackBox.TabIndex = 3;
            this.autoAttackBox.Text = "Автостарт";
            this.autoAttackBox.UseVisualStyleBackColor = true;
            this.autoAttackBox.CheckedChanged += new System.EventHandler(this.autoAttackBox_CheckedChanged);
            // 
            // startupBox
            // 
            this.startupBox.AutoSize = true;
            this.startupBox.Location = new System.Drawing.Point(12, 12);
            this.startupBox.Name = "startupBox";
            this.startupBox.Size = new System.Drawing.Size(180, 17);
            this.startupBox.TabIndex = 1;
            this.startupBox.Text = "Запускать вместе с системой";
            this.startupBox.UseVisualStyleBackColor = true;
            this.startupBox.CheckedChanged += new System.EventHandler(this.startupBox_CheckedChanged);
            // 
            // sendStatisticsBox
            // 
            this.sendStatisticsBox.AutoSize = true;
            this.sendStatisticsBox.Location = new System.Drawing.Point(12, 105);
            this.sendStatisticsBox.Name = "sendStatisticsBox";
            this.sendStatisticsBox.Size = new System.Drawing.Size(145, 17);
            this.sendStatisticsBox.TabIndex = 4;
            this.sendStatisticsBox.Text = "Отправлять статистику";
            this.sendStatisticsBox.UseVisualStyleBackColor = true;
            this.sendStatisticsBox.CheckedChanged += new System.EventHandler(this.sendDataBox_CheckedChanged);
            // 
            // saveCredentialsBox
            // 
            this.saveCredentialsBox.AutoSize = true;
            this.saveCredentialsBox.Location = new System.Drawing.Point(12, 82);
            this.saveCredentialsBox.Name = "saveCredentialsBox";
            this.saveCredentialsBox.Size = new System.Drawing.Size(168, 17);
            this.saveCredentialsBox.TabIndex = 6;
            this.saveCredentialsBox.Text = "Запоминать логин и пароль";
            this.saveCredentialsBox.UseVisualStyleBackColor = true;
            this.saveCredentialsBox.CheckedChanged += new System.EventHandler(this.saveCredentialsBox_CheckedChanged);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 132);
            this.Controls.Add(this.saveCredentialsBox);
            this.Controls.Add(this.sendStatisticsBox);
            this.Controls.Add(this.autoAttackBox);
            this.Controls.Add(this.hiddenStartBox);
            this.Controls.Add(this.startupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.settingsForm_FormClosing);
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox startupBox;
        private System.Windows.Forms.CheckBox hiddenStartBox;
        private System.Windows.Forms.CheckBox autoAttackBox;
        private System.Windows.Forms.CheckBox sendStatisticsBox;
        private System.Windows.Forms.CheckBox saveCredentialsBox;
    }
}