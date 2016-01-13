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
            this.label1 = new System.Windows.Forms.Label();
            this.startupBox = new System.Windows.Forms.CheckBox();
            this.hiddenStartBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Для удобства можно добавить эту программу в автозагрузку.";
            // 
            // startupBox
            // 
            this.startupBox.AutoSize = true;
            this.startupBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::PikabuInvaders.Properties.Settings.Default, "hiddenStart", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.startupBox.Enabled = global::PikabuInvaders.Properties.Settings.Default.hiddenStart;
            this.startupBox.Location = new System.Drawing.Point(10, 55);
            this.startupBox.Name = "startupBox";
            this.startupBox.Size = new System.Drawing.Size(175, 17);
            this.startupBox.TabIndex = 1;
            this.startupBox.Text = "Запускать вместе с Windows";
            this.startupBox.UseVisualStyleBackColor = true;
            this.startupBox.CheckedChanged += new System.EventHandler(this.startupBox_CheckedChanged);
            // 
            // hiddenStartBox
            // 
            this.hiddenStartBox.AutoSize = true;
            this.hiddenStartBox.Enabled = false;
            this.hiddenStartBox.Location = new System.Drawing.Point(10, 78);
            this.hiddenStartBox.Name = "hiddenStartBox";
            this.hiddenStartBox.Size = new System.Drawing.Size(128, 17);
            this.hiddenStartBox.TabIndex = 2;
            this.hiddenStartBox.Text = "Запускать свёрнуто";
            this.hiddenStartBox.UseVisualStyleBackColor = true;
            this.hiddenStartBox.CheckedChanged += new System.EventHandler(this.hiddenStartBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Будет отображаться в трее (обычно справа снизу).";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.hiddenStartBox);
            this.groupBox1.Controls.Add(this.startupBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общие";
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox startupBox;
        private System.Windows.Forms.CheckBox hiddenStartBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}