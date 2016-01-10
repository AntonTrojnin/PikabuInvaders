namespace PikabuInvaders
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.startButton = new System.Windows.Forms.Button();
            this.passBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.logBox = new System.Windows.Forms.TextBox();
            this.checkNewPosts = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(427, 13);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 25);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(220, 16);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(200, 20);
            this.passBox.TabIndex = 1;
            this.passBox.Text = "Пароль";
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(12, 16);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(200, 20);
            this.loginBox.TabIndex = 0;
            this.loginBox.Text = "Логин";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(12, 44);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(490, 205);
            this.logBox.TabIndex = 3;
            // 
            // checkNewPosts
            // 
            this.checkNewPosts.Interval = 20000;
            this.checkNewPosts.Tick += new System.EventHandler(this.checkNewPosts_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 261);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.startButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(530, 300);
            this.MinimumSize = new System.Drawing.Size(530, 300);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pikabu Invaders";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer checkNewPosts;
    }
}

