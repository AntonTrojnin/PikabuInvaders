﻿namespace PikabuInvaders
{
    partial class chooseForm
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
            this.goodForceButton = new System.Windows.Forms.Button();
            this.forceEvilButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goodForceButton
            // 
            this.goodForceButton.BackColor = System.Drawing.Color.Green;
            this.goodForceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goodForceButton.ForeColor = System.Drawing.SystemColors.Control;
            this.goodForceButton.Location = new System.Drawing.Point(12, 71);
            this.goodForceButton.Name = "goodForceButton";
            this.goodForceButton.Size = new System.Drawing.Size(150, 60);
            this.goodForceButton.TabIndex = 0;
            this.goodForceButton.Text = "Лига добра";
            this.goodForceButton.UseVisualStyleBackColor = false;
            this.goodForceButton.Click += new System.EventHandler(this.goodForceButton_Click);
            // 
            // forceEvilButton
            // 
            this.forceEvilButton.BackColor = System.Drawing.Color.DarkRed;
            this.forceEvilButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.forceEvilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forceEvilButton.ForeColor = System.Drawing.SystemColors.Control;
            this.forceEvilButton.Location = new System.Drawing.Point(172, 71);
            this.forceEvilButton.Name = "forceEvilButton";
            this.forceEvilButton.Size = new System.Drawing.Size(150, 60);
            this.forceEvilButton.TabIndex = 1;
            this.forceEvilButton.Text = "Лига зла";
            this.forceEvilButton.UseVisualStyleBackColor = false;
            this.forceEvilButton.Click += new System.EventHandler(this.forceEvilButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "Прежде чем начать, выбери свою сторону. Можно встать на сторону света и присоедин" +
    "иться к лиге добра, либо примкнуть к тёмным силам и присоединиться к лиге зла. В" +
    "ыбор за тобой...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 143);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forceEvilButton);
            this.Controls.Add(this.goodForceButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "chooseForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "На чьей ты стороне?";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goodForceButton;
        private System.Windows.Forms.Button forceEvilButton;
        private System.Windows.Forms.Label label1;
    }
}