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
            this.userSideComboBox = new System.Windows.Forms.ComboBox();
            this.sideLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hiddenStartBox
            // 
            this.hiddenStartBox.AutoSize = true;
            this.hiddenStartBox.Enabled = false;
            this.hiddenStartBox.Location = new System.Drawing.Point(6, 97);
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
            this.autoAttackBox.Location = new System.Drawing.Point(6, 120);
            this.autoAttackBox.Name = "autoAttackBox";
            this.autoAttackBox.Size = new System.Drawing.Size(164, 17);
            this.autoAttackBox.TabIndex = 3;
            this.autoAttackBox.Text = "Стартовать автоматически";
            this.autoAttackBox.UseVisualStyleBackColor = true;
            this.autoAttackBox.CheckedChanged += new System.EventHandler(this.autoAttackBox_CheckedChanged);
            // 
            // startupBox
            // 
            this.startupBox.AutoSize = true;
            this.startupBox.Location = new System.Drawing.Point(6, 74);
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
            this.sendStatisticsBox.Location = new System.Drawing.Point(6, 120);
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
            this.saveCredentialsBox.Location = new System.Drawing.Point(6, 63);
            this.saveCredentialsBox.Name = "saveCredentialsBox";
            this.saveCredentialsBox.Size = new System.Drawing.Size(168, 17);
            this.saveCredentialsBox.TabIndex = 6;
            this.saveCredentialsBox.Text = "Запоминать логин и пароль";
            this.saveCredentialsBox.UseVisualStyleBackColor = true;
            this.saveCredentialsBox.CheckedChanged += new System.EventHandler(this.saveCredentialsBox_CheckedChanged);
            // 
            // userSideComboBox
            // 
            this.userSideComboBox.FormattingEnabled = true;
            this.userSideComboBox.Items.AddRange(new object[] {
            "Лига добра",
            "Лига зла"});
            this.userSideComboBox.Location = new System.Drawing.Point(6, 47);
            this.userSideComboBox.Name = "userSideComboBox";
            this.userSideComboBox.Size = new System.Drawing.Size(199, 21);
            this.userSideComboBox.TabIndex = 7;
            this.userSideComboBox.SelectedIndexChanged += new System.EventHandler(this.sideComboBox_SelectedIndexChanged);
            // 
            // sideLabel
            // 
            this.sideLabel.Location = new System.Drawing.Point(6, 16);
            this.sideLabel.Name = "sideLabel";
            this.sideLabel.Size = new System.Drawing.Size(199, 28);
            this.sideLabel.TabIndex = 9;
            this.sideLabel.Text = "Ты можешь поменять свою сторону в любой момент.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userSideComboBox);
            this.groupBox1.Controls.Add(this.sideLabel);
            this.groupBox1.Controls.Add(this.hiddenStartBox);
            this.groupBox1.Controls.Add(this.startupBox);
            this.groupBox1.Controls.Add(this.autoAttackBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 143);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основные";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.sendStatisticsBox);
            this.groupBox2.Controls.Add(this.saveCredentialsBox);
            this.groupBox2.Location = new System.Drawing.Point(229, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 143);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дополнительно";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Если хочешь, чтобы программа запоминала введённый логин и пароль.";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Отключи, если не хочешь учавстовать в рейтинге.";
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 167);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox startupBox;
        private System.Windows.Forms.CheckBox hiddenStartBox;
        private System.Windows.Forms.CheckBox autoAttackBox;
        private System.Windows.Forms.CheckBox sendStatisticsBox;
        private System.Windows.Forms.CheckBox saveCredentialsBox;
        private System.Windows.Forms.ComboBox userSideComboBox;
        private System.Windows.Forms.Label sideLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}