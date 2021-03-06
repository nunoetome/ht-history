﻿namespace HtHistory
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offlineModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatsNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutHtHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePlayers = new System.Windows.Forms.TabPage();
            this.comboBoxColumnSets = new System.Windows.Forms.ComboBox();
            this.buttonColumns = new System.Windows.Forms.Button();
            this.overviewPage1 = new HtHistory.Pages.OverviewPage();
            this.tabPageMatches = new System.Windows.Forms.TabPage();
            this.matchesPage1 = new HtHistory.Pages.MatchesPage();
            this.tabPageTransfers = new System.Windows.Forms.TabPage();
            this.transfersPage1 = new HtHistory.Pages.TransfersPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.matchFilterControl = new HtHistory.UserControls.MatchFilterControl();
            this.menuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPagePlayers.SuspendLayout();
            this.tabPageMatches.SuspendLayout();
            this.tabPageTransfers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(884, 24);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearCacheToolStripMenuItem,
            this.offlineModeToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // clearCacheToolStripMenuItem
            // 
            this.clearCacheToolStripMenuItem.Name = "clearCacheToolStripMenuItem";
            this.clearCacheToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.clearCacheToolStripMenuItem.Text = "Clear cache";
            this.clearCacheToolStripMenuItem.Click += new System.EventHandler(this.clearCacheToolStripMenuItem_Click);
            // 
            // offlineModeToolStripMenuItem
            // 
            this.offlineModeToolStripMenuItem.Enabled = false;
            this.offlineModeToolStripMenuItem.Name = "offlineModeToolStripMenuItem";
            this.offlineModeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.offlineModeToolStripMenuItem.Text = "Work offline";
            this.offlineModeToolStripMenuItem.Visible = false;
            this.offlineModeToolStripMenuItem.Click += new System.EventHandler(this.offlineModeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proxyToolStripMenuItem,
            this.columnsToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // proxyToolStripMenuItem
            // 
            this.proxyToolStripMenuItem.Name = "proxyToolStripMenuItem";
            this.proxyToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.proxyToolStripMenuItem.Text = "Proxy...";
            this.proxyToolStripMenuItem.Click += new System.EventHandler(this.proxyToolStripMenuItem_Click);
            // 
            // columnsToolStripMenuItem
            // 
            this.columnsToolStripMenuItem.Name = "columnsToolStripMenuItem";
            this.columnsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.columnsToolStripMenuItem.Text = "Columns...";
            this.columnsToolStripMenuItem.Click += new System.EventHandler(this.columnsToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.whatsNewToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutHtHistoryToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.helpToolStripMenuItem.Text = "Help...";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.updateToolStripMenuItem.Text = "Update...";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // whatsNewToolStripMenuItem
            // 
            this.whatsNewToolStripMenuItem.Name = "whatsNewToolStripMenuItem";
            this.whatsNewToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.whatsNewToolStripMenuItem.Text = "What\'s new...";
            this.whatsNewToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItemWhatsNew_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(175, 6);
            // 
            // aboutHtHistoryToolStripMenuItem
            // 
            this.aboutHtHistoryToolStripMenuItem.Name = "aboutHtHistoryToolStripMenuItem";
            this.aboutHtHistoryToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.aboutHtHistoryToolStripMenuItem.Text = "About HT-History...";
            this.aboutHtHistoryToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(118, 126);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(104, 34);
            this.buttonRefresh.TabIndex = 13;
            this.buttonRefresh.Text = "change team\r\n/ refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPagePlayers);
            this.tabControl1.Controls.Add(this.tabPageMatches);
            this.tabControl1.Controls.Add(this.tabPageTransfers);
            this.tabControl1.Location = new System.Drawing.Point(15, 176);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(857, 474);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPagePlayers
            // 
            this.tabPagePlayers.Controls.Add(this.comboBoxColumnSets);
            this.tabPagePlayers.Controls.Add(this.buttonColumns);
            this.tabPagePlayers.Controls.Add(this.overviewPage1);
            this.tabPagePlayers.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlayers.Name = "tabPagePlayers";
            this.tabPagePlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlayers.Size = new System.Drawing.Size(849, 448);
            this.tabPagePlayers.TabIndex = 2;
            this.tabPagePlayers.Text = "Players";
            this.tabPagePlayers.UseVisualStyleBackColor = true;
            // 
            // comboBoxColumnSets
            // 
            this.comboBoxColumnSets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxColumnSets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColumnSets.FormattingEnabled = true;
            this.comboBoxColumnSets.Location = new System.Drawing.Point(568, 7);
            this.comboBoxColumnSets.Name = "comboBoxColumnSets";
            this.comboBoxColumnSets.Size = new System.Drawing.Size(208, 21);
            this.comboBoxColumnSets.TabIndex = 16;
            this.comboBoxColumnSets.SelectedIndexChanged += new System.EventHandler(this.comboBoxColumnSets_SelectedIndexChanged);
            // 
            // buttonColumns
            // 
            this.buttonColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonColumns.Location = new System.Drawing.Point(782, 6);
            this.buttonColumns.Name = "buttonColumns";
            this.buttonColumns.Size = new System.Drawing.Size(61, 23);
            this.buttonColumns.TabIndex = 15;
            this.buttonColumns.Text = "columns";
            this.buttonColumns.UseVisualStyleBackColor = true;
            this.buttonColumns.Click += new System.EventHandler(this.button2_Click);
            // 
            // overviewPage1
            // 
            this.overviewPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewPage1.Location = new System.Drawing.Point(3, 3);
            this.overviewPage1.Name = "overviewPage1";
            this.overviewPage1.Size = new System.Drawing.Size(843, 442);
            this.overviewPage1.Stats = null;
            this.overviewPage1.TabIndex = 0;
            // 
            // tabPageMatches
            // 
            this.tabPageMatches.Controls.Add(this.matchesPage1);
            this.tabPageMatches.Location = new System.Drawing.Point(4, 22);
            this.tabPageMatches.Name = "tabPageMatches";
            this.tabPageMatches.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMatches.Size = new System.Drawing.Size(849, 448);
            this.tabPageMatches.TabIndex = 3;
            this.tabPageMatches.Text = "Matches";
            this.tabPageMatches.UseVisualStyleBackColor = true;
            // 
            // matchesPage1
            // 
            this.matchesPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchesPage1.Location = new System.Drawing.Point(3, 3);
            this.matchesPage1.Name = "matchesPage1";
            this.matchesPage1.Size = new System.Drawing.Size(843, 442);
            this.matchesPage1.TabIndex = 0;
            // 
            // tabPageTransfers
            // 
            this.tabPageTransfers.Controls.Add(this.transfersPage1);
            this.tabPageTransfers.Location = new System.Drawing.Point(4, 22);
            this.tabPageTransfers.Name = "tabPageTransfers";
            this.tabPageTransfers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTransfers.Size = new System.Drawing.Size(849, 448);
            this.tabPageTransfers.TabIndex = 4;
            this.tabPageTransfers.Text = "Transfers";
            this.tabPageTransfers.UseVisualStyleBackColor = true;
            // 
            // transfersPage1
            // 
            this.transfersPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transfersPage1.Location = new System.Drawing.Point(3, 3);
            this.transfersPage1.Name = "transfersPage1";
            this.transfersPage1.Size = new System.Drawing.Size(843, 442);
            this.transfersPage1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HtHistory.Images.HtHistoryBallOnly;
            this.pictureBox1.Location = new System.Drawing.Point(784, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 75);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // matchFilterControl
            // 
            this.matchFilterControl.BackColor = System.Drawing.Color.Transparent;
            this.matchFilterControl.ForeColor = System.Drawing.Color.White;
            this.matchFilterControl.Location = new System.Drawing.Point(22, 40);
            this.matchFilterControl.Name = "matchFilterControl";
            this.matchFilterControl.Size = new System.Drawing.Size(691, 130);
            this.matchFilterControl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(884, 662);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.matchFilterControl);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPagePlayers.ResumeLayout(false);
            this.tabPageMatches.ResumeLayout(false);
            this.tabPageTransfers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem offlineModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proxyToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPagePlayers;
        private Pages.OverviewPage overviewPage1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem columnsToolStripMenuItem;
        private System.Windows.Forms.Button buttonColumns;
        private System.Windows.Forms.ComboBox comboBoxColumnSets;
        private System.Windows.Forms.TabPage tabPageMatches;
        private Pages.MatchesPage matchesPage1;
        private UserControls.MatchFilterControl matchFilterControl;
        private System.Windows.Forms.TabPage tabPageTransfers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutHtHistoryToolStripMenuItem;
        private Pages.TransfersPage transfersPage1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatsNewToolStripMenuItem;
    }
}

