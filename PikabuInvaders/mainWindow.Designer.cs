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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.startButton = new System.Windows.Forms.Button();
            this.passBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.logBox = new System.Windows.Forms.TextBox();
            this.checkNewPosts = new System.Windows.Forms.Timer(this.components);
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.settingsMenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkPosts = new System.Windows.Forms.Timer(this.components);
            this.sendStatistics = new System.Windows.Forms.Timer(this.components);
            this.tabs = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.ratingPage = new System.Windows.Forms.TabPage();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.ratingGrid = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.votes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userSideLabel = new System.Windows.Forms.Label();
            this.userSideTextLabel = new System.Windows.Forms.Label();
            this.inWork = new System.Windows.Forms.Label();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.siteLabel = new System.Windows.Forms.LinkLabel();
            this.checkInternetTimer = new System.Windows.Forms.Timer(this.components);
            this.mainMenu.SuspendLayout();
            this.tabs.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.ratingPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(318, 6);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(80, 25);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(162, 9);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(150, 20);
            this.passBox.TabIndex = 1;
            this.passBox.Text = "Пароль";
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(6, 9);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(150, 20);
            this.loginBox.TabIndex = 0;
            this.loginBox.Text = "Логин";
            // 
            // logBox
            // 
            this.logBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.logBox.Location = new System.Drawing.Point(6, 37);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.ShortcutsEnabled = false;
            this.logBox.Size = new System.Drawing.Size(391, 141);
            this.logBox.TabIndex = 3;
            // 
            // checkNewPosts
            // 
            this.checkNewPosts.Interval = 30000;
            this.checkNewPosts.Tick += new System.EventHandler(this.checkNewPosts_Tick);
            // 
            // notify
            // 
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "Pikabu Invaders";
            this.notify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notify_MouseDoubleClick);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsMenuitem,
            this.aboutMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(434, 24);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "menuStrip1";
            // 
            // settingsMenuitem
            // 
            this.settingsMenuitem.Name = "settingsMenuitem";
            this.settingsMenuitem.Size = new System.Drawing.Size(79, 20);
            this.settingsMenuitem.Text = "Настройки";
            this.settingsMenuitem.Click += new System.EventHandler(this.settingsMenuitem_Click);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(94, 20);
            this.aboutMenuItem.Text = "О программе";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // checkPosts
            // 
            this.checkPosts.Interval = 3000;
            this.checkPosts.Tick += new System.EventHandler(this.checkPosts_Tick);
            // 
            // sendStatistics
            // 
            this.sendStatistics.Interval = 50000;
            this.sendStatistics.Tick += new System.EventHandler(this.sendStatistics_Tick);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.mainPage);
            this.tabs.Controls.Add(this.ratingPage);
            this.tabs.Location = new System.Drawing.Point(12, 27);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(410, 210);
            this.tabs.TabIndex = 5;
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.logBox);
            this.mainPage.Controls.Add(this.startButton);
            this.mainPage.Controls.Add(this.loginBox);
            this.mainPage.Controls.Add(this.passBox);
            this.mainPage.Location = new System.Drawing.Point(4, 22);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(402, 184);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "Основное";
            this.mainPage.UseVisualStyleBackColor = true;
            // 
            // ratingPage
            // 
            this.ratingPage.Controls.Add(this.ratingGrid);
            this.ratingPage.Controls.Add(this.loadingLabel);
            this.ratingPage.Location = new System.Drawing.Point(4, 22);
            this.ratingPage.Margin = new System.Windows.Forms.Padding(0);
            this.ratingPage.Name = "ratingPage";
            this.ratingPage.Size = new System.Drawing.Size(402, 184);
            this.ratingPage.TabIndex = 1;
            this.ratingPage.Text = "Рейтинг";
            this.ratingPage.Enter += new System.EventHandler(this.tabPage2_Enter);
            this.ratingPage.Leave += new System.EventHandler(this.tabPage2_Leave);
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadingLabel.Location = new System.Drawing.Point(101, 73);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(195, 24);
            this.loadingLabel.TabIndex = 0;
            this.loadingLabel.Text = "Загрузка рейтинга...";
            // 
            // ratingGrid
            // 
            this.ratingGrid.AllowUserToAddRows = false;
            this.ratingGrid.AllowUserToDeleteRows = false;
            this.ratingGrid.AllowUserToResizeColumns = false;
            this.ratingGrid.AllowUserToResizeRows = false;
            this.ratingGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ratingGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ratingGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ratingGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ratingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ratingGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.username,
            this.votes});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ratingGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.ratingGrid.Location = new System.Drawing.Point(-4, 0);
            this.ratingGrid.Name = "ratingGrid";
            this.ratingGrid.ReadOnly = true;
            this.ratingGrid.RowHeadersVisible = false;
            this.ratingGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ratingGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ratingGrid.ShowCellErrors = false;
            this.ratingGrid.ShowCellToolTips = false;
            this.ratingGrid.ShowEditingIcon = false;
            this.ratingGrid.ShowRowErrors = false;
            this.ratingGrid.Size = new System.Drawing.Size(410, 188);
            this.ratingGrid.TabIndex = 3;
            this.ratingGrid.Visible = false;
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.number.Frozen = true;
            this.number.HeaderText = "#";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 30;
            // 
            // username
            // 
            this.username.HeaderText = "Ник";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // votes
            // 
            this.votes.HeaderText = "Оценок";
            this.votes.Name = "votes";
            this.votes.ReadOnly = true;
            // 
            // userSideLabel
            // 
            this.userSideLabel.AutoSize = true;
            this.userSideLabel.Location = new System.Drawing.Point(13, 240);
            this.userSideLabel.Name = "userSideLabel";
            this.userSideLabel.Size = new System.Drawing.Size(63, 13);
            this.userSideLabel.TabIndex = 6;
            this.userSideLabel.Text = "Ваша лига:";
            // 
            // userSideTextLabel
            // 
            this.userSideTextLabel.AutoSize = true;
            this.userSideTextLabel.Location = new System.Drawing.Point(73, 240);
            this.userSideTextLabel.Name = "userSideTextLabel";
            this.userSideTextLabel.Size = new System.Drawing.Size(68, 13);
            this.userSideTextLabel.TabIndex = 8;
            this.userSideTextLabel.Text = "USER_SIDE";
            // 
            // inWork
            // 
            this.inWork.AutoSize = true;
            this.inWork.Location = new System.Drawing.Point(182, 240);
            this.inWork.Name = "inWork";
            this.inWork.Size = new System.Drawing.Size(74, 13);
            this.inWork.TabIndex = 9;
            this.inWork.Text = "Остановлено";
            this.inWork.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeTimer
            // 
            this.timeTimer.Interval = 200;
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // siteLabel
            // 
            this.siteLabel.AutoSize = true;
            this.siteLabel.Location = new System.Drawing.Point(292, 240);
            this.siteLabel.Name = "siteLabel";
            this.siteLabel.Size = new System.Drawing.Size(122, 13);
            this.siteLabel.TabIndex = 10;
            this.siteLabel.TabStop = true;
            this.siteLabel.Text = "http://pikabuinvaders.ru";
            this.siteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.siteLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.siteLabel_LinkClicked);
            // 
            // checkInternetTimer
            // 
            this.checkInternetTimer.Interval = 5000;
            this.checkInternetTimer.Tick += new System.EventHandler(this.checkInternetTimer_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 260);
            this.Controls.Add(this.siteLabel);
            this.Controls.Add(this.inWork);
            this.Controls.Add(this.userSideTextLabel);
            this.Controls.Add(this.userSideLabel);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pikabu Invaders";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.mainPage.PerformLayout();
            this.ratingPage.ResumeLayout(false);
            this.ratingPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer checkNewPosts;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuitem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.Timer checkPosts;
        private System.Windows.Forms.Timer sendStatistics;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.Label userSideLabel;
        private System.Windows.Forms.Label userSideTextLabel;
        private System.Windows.Forms.Label inWork;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.DataGridView ratingGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn votes;
        private System.Windows.Forms.LinkLabel siteLabel;
        private System.Windows.Forms.Timer checkInternetTimer;
        private System.Windows.Forms.TabPage ratingPage;
    }
}

