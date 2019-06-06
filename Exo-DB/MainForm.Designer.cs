﻿namespace EXO_DB
{
	partial class MainForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
			this.kryptonDockingManager = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
			this.kryptonNavigator = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
			this.kryptonPageLoadDatabase = new ComponentFactory.Krypton.Navigator.KryptonPage();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.progressBarLoadingDatabase = new System.Windows.Forms.ProgressBar();
			this.kryptonButtonSaveInternalDatabase = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.kryptonWrapLabelStatusOfProgressingDatabase = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
			this.kryptonButtonLoadOnlineDatabase = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.kryptonButtonLoadInternalDatabase = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.kryptonButtonLoadExternalDatabase = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.kryptonButtonSaveOnlineDatabase = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonInformation = new System.Windows.Forms.ToolStripButton();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemInfo = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.statusStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
			this.kryptonPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator)).BeginInit();
			this.kryptonNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPageLoadDatabase)).BeginInit();
			this.kryptonPageLoadDatabase.SuspendLayout();
			this.tableLayoutPanel.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.toolStripContainer2.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer2.ContentPanel.SuspendLayout();
			this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.Size = new System.Drawing.Size(784, 22);
			this.statusStrip.TabIndex = 0;
			this.statusStrip.Text = "statusStrip";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(70, 17);
			this.toolStripStatusLabel.Text = "information";
			// 
			// kryptonPanel
			// 
			this.kryptonPanel.Controls.Add(this.kryptonNavigator);
			this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
			this.kryptonPanel.Name = "kryptonPanel";
			this.kryptonPanel.Size = new System.Drawing.Size(784, 371);
			this.kryptonPanel.TabIndex = 2;
			// 
			// kryptonNavigator
			// 
			this.kryptonNavigator.Bar.TabBorderStyle = ComponentFactory.Krypton.Toolkit.TabBorderStyle.RoundedOutsizeSmall;
			this.kryptonNavigator.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
			this.kryptonNavigator.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
			this.kryptonNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonNavigator.Location = new System.Drawing.Point(0, 0);
			this.kryptonNavigator.Name = "kryptonNavigator";
			this.kryptonNavigator.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
			this.kryptonNavigator.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPageLoadDatabase});
			this.kryptonNavigator.SelectedIndex = 0;
			this.kryptonNavigator.Size = new System.Drawing.Size(784, 371);
			this.kryptonNavigator.TabIndex = 0;
			this.kryptonNavigator.Text = "kryptonNavigator1";
			// 
			// kryptonPageLoadDatabase
			// 
			this.kryptonPageLoadDatabase.AccessibleDescription = "Lädt die Datenbank";
			this.kryptonPageLoadDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
			this.kryptonPageLoadDatabase.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
			this.kryptonPageLoadDatabase.Controls.Add(this.tableLayoutPanel);
			this.kryptonPageLoadDatabase.Flags = 65534;
			this.kryptonPageLoadDatabase.ImageSmall = global::EXO_DB.Properties.Resources.database;
			this.kryptonPageLoadDatabase.LastVisibleSet = true;
			this.kryptonPageLoadDatabase.MinimumSize = new System.Drawing.Size(50, 50);
			this.kryptonPageLoadDatabase.Name = "kryptonPageLoadDatabase";
			this.kryptonPageLoadDatabase.Size = new System.Drawing.Size(782, 344);
			this.kryptonPageLoadDatabase.Text = "Datenbank laden";
			this.kryptonPageLoadDatabase.ToolTipBody = "Datenbank laden";
			this.kryptonPageLoadDatabase.ToolTipTitle = "Page ToolTip";
			this.kryptonPageLoadDatabase.UniqueName = "A9B4B29D3AE24812CD9D8154EC44F9D0";
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
			this.tableLayoutPanel.ColumnCount = 3;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel.Controls.Add(this.progressBarLoadingDatabase, 0, 3);
			this.tableLayoutPanel.Controls.Add(this.kryptonButtonSaveInternalDatabase, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.kryptonWrapLabelStatusOfProgressingDatabase, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.kryptonButtonLoadOnlineDatabase, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.kryptonButtonLoadInternalDatabase, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.kryptonButtonLoadExternalDatabase, 2, 0);
			this.tableLayoutPanel.Controls.Add(this.kryptonButtonSaveOnlineDatabase, 1, 1);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 4;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(782, 344);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// progressBarLoadingDatabase
			// 
			this.tableLayoutPanel.SetColumnSpan(this.progressBarLoadingDatabase, 3);
			this.progressBarLoadingDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.progressBarLoadingDatabase.Location = new System.Drawing.Point(3, 327);
			this.progressBarLoadingDatabase.Name = "progressBarLoadingDatabase";
			this.progressBarLoadingDatabase.Size = new System.Drawing.Size(776, 14);
			this.progressBarLoadingDatabase.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBarLoadingDatabase.TabIndex = 5;
			// 
			// kryptonButtonSaveInternalDatabase
			// 
			this.kryptonButtonSaveInternalDatabase.AccessibleDescription = "Speichert die interne Datenbank ab";
			this.kryptonButtonSaveInternalDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonSaveInternalDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonButtonSaveInternalDatabase.Location = new System.Drawing.Point(3, 268);
			this.kryptonButtonSaveInternalDatabase.Name = "kryptonButtonSaveInternalDatabase";
			this.kryptonButtonSaveInternalDatabase.Size = new System.Drawing.Size(254, 33);
			this.kryptonButtonSaveInternalDatabase.TabIndex = 3;
			this.toolTip.SetToolTip(this.kryptonButtonSaveInternalDatabase, "Interne Datenbank speichern");
			this.kryptonButtonSaveInternalDatabase.Values.Image = global::EXO_DB.Properties.Resources.database_save;
			this.kryptonButtonSaveInternalDatabase.Values.Text = "Interne Datenbank speichern";
			this.kryptonButtonSaveInternalDatabase.Click += new System.EventHandler(this.KryptonButtonSaveInternalDatabase_Click);
			this.kryptonButtonSaveInternalDatabase.Enter += new System.EventHandler(this.KryptonButtonSaveInternalDatabase_Enter);
			this.kryptonButtonSaveInternalDatabase.Leave += new System.EventHandler(this.KryptonButtonSaveInternalDatabase_Leave);
			this.kryptonButtonSaveInternalDatabase.MouseEnter += new System.EventHandler(this.KryptonButtonSaveInternalDatabase_MouseEnter);
			this.kryptonButtonSaveInternalDatabase.MouseLeave += new System.EventHandler(this.KryptonButtonSaveInternalDatabase_MouseLeave);
			// 
			// kryptonWrapLabelStatusOfProgressingDatabase
			// 
			this.tableLayoutPanel.SetColumnSpan(this.kryptonWrapLabelStatusOfProgressingDatabase, 3);
			this.kryptonWrapLabelStatusOfProgressingDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonWrapLabelStatusOfProgressingDatabase.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.kryptonWrapLabelStatusOfProgressingDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
			this.kryptonWrapLabelStatusOfProgressingDatabase.Location = new System.Drawing.Point(3, 304);
			this.kryptonWrapLabelStatusOfProgressingDatabase.Name = "kryptonWrapLabelStatusOfProgressingDatabase";
			this.kryptonWrapLabelStatusOfProgressingDatabase.Size = new System.Drawing.Size(776, 20);
			this.kryptonWrapLabelStatusOfProgressingDatabase.Text = "Show status of progressing database";
			// 
			// kryptonButtonLoadOnlineDatabase
			// 
			this.kryptonButtonLoadOnlineDatabase.AccessibleDescription = "Lädt die Online-Datenbank";
			this.kryptonButtonLoadOnlineDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonLoadOnlineDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonButtonLoadOnlineDatabase.Location = new System.Drawing.Point(263, 3);
			this.kryptonButtonLoadOnlineDatabase.Name = "kryptonButtonLoadOnlineDatabase";
			this.kryptonButtonLoadOnlineDatabase.Size = new System.Drawing.Size(254, 259);
			this.kryptonButtonLoadOnlineDatabase.TabIndex = 1;
			this.toolTip.SetToolTip(this.kryptonButtonLoadOnlineDatabase, "Online-Datenbank laden");
			this.kryptonButtonLoadOnlineDatabase.Values.Image = global::EXO_DB.Properties.Resources.database_lightning_32;
			this.kryptonButtonLoadOnlineDatabase.Values.Text = "Online-Datenbank laden";
			this.kryptonButtonLoadOnlineDatabase.Click += new System.EventHandler(this.KryptonButtonLoadOnlineDatabase_Click);
			this.kryptonButtonLoadOnlineDatabase.Enter += new System.EventHandler(this.KryptonButtonLoadOnlineDatabase_Enter);
			this.kryptonButtonLoadOnlineDatabase.Leave += new System.EventHandler(this.KryptonButtonLoadOnlineDatabase_Leave);
			this.kryptonButtonLoadOnlineDatabase.MouseEnter += new System.EventHandler(this.KryptonButtonLoadOnlineDatabase_MouseEnter);
			this.kryptonButtonLoadOnlineDatabase.MouseLeave += new System.EventHandler(this.KryptonButtonLoadOnlineDatabase_MouseLeave);
			// 
			// kryptonButtonLoadInternalDatabase
			// 
			this.kryptonButtonLoadInternalDatabase.AccessibleDescription = "Lädt die interne Datenbank";
			this.kryptonButtonLoadInternalDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonLoadInternalDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonButtonLoadInternalDatabase.Location = new System.Drawing.Point(3, 3);
			this.kryptonButtonLoadInternalDatabase.Name = "kryptonButtonLoadInternalDatabase";
			this.kryptonButtonLoadInternalDatabase.Size = new System.Drawing.Size(254, 259);
			this.kryptonButtonLoadInternalDatabase.TabIndex = 0;
			this.toolTip.SetToolTip(this.kryptonButtonLoadInternalDatabase, "Interne Datenbank laden");
			this.kryptonButtonLoadInternalDatabase.Values.Image = global::EXO_DB.Properties.Resources.database_32;
			this.kryptonButtonLoadInternalDatabase.Values.Text = "Interne Datenbank laden";
			this.kryptonButtonLoadInternalDatabase.Click += new System.EventHandler(this.KryptonButtonLoadInternalDatabase_Click);
			this.kryptonButtonLoadInternalDatabase.Enter += new System.EventHandler(this.KryptonButtonLoadInternalDatabase_Enter);
			this.kryptonButtonLoadInternalDatabase.Leave += new System.EventHandler(this.KryptonButtonLoadInternalDatabase_Leave);
			this.kryptonButtonLoadInternalDatabase.MouseEnter += new System.EventHandler(this.KryptonButtonLoadInternalDatabase_MouseEnter);
			this.kryptonButtonLoadInternalDatabase.MouseLeave += new System.EventHandler(this.KryptonButtonLoadInternalDatabase_MouseLeave);
			// 
			// kryptonButtonLoadExternalDatabase
			// 
			this.kryptonButtonLoadExternalDatabase.AccessibleDescription = "Lädt die externe Datenbank";
			this.kryptonButtonLoadExternalDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonLoadExternalDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonButtonLoadExternalDatabase.Location = new System.Drawing.Point(523, 3);
			this.kryptonButtonLoadExternalDatabase.Name = "kryptonButtonLoadExternalDatabase";
			this.kryptonButtonLoadExternalDatabase.Size = new System.Drawing.Size(256, 259);
			this.kryptonButtonLoadExternalDatabase.TabIndex = 2;
			this.toolTip.SetToolTip(this.kryptonButtonLoadExternalDatabase, "Externe Datenbank laden");
			this.kryptonButtonLoadExternalDatabase.Values.Image = global::EXO_DB.Properties.Resources.database_go_32;
			this.kryptonButtonLoadExternalDatabase.Values.Text = "Externe Datenbank laden";
			this.kryptonButtonLoadExternalDatabase.Click += new System.EventHandler(this.KryptonButtonLoadExternalDatabase_Click);
			this.kryptonButtonLoadExternalDatabase.Enter += new System.EventHandler(this.KryptonButtonLoadExternalDatabase_Enter);
			this.kryptonButtonLoadExternalDatabase.Leave += new System.EventHandler(this.KryptonButtonLoadExternalDatabase_Leave);
			this.kryptonButtonLoadExternalDatabase.MouseEnter += new System.EventHandler(this.KryptonButtonLoadExternalDatabase_MouseEnter);
			this.kryptonButtonLoadExternalDatabase.MouseLeave += new System.EventHandler(this.KryptonButtonLoadExternalDatabase_MouseLeave);
			// 
			// kryptonButtonSaveOnlineDatabase
			// 
			this.kryptonButtonSaveOnlineDatabase.AccessibleDescription = "Speichert die Online-Datenbank ab";
			this.kryptonButtonSaveOnlineDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonSaveOnlineDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonButtonSaveOnlineDatabase.Location = new System.Drawing.Point(263, 268);
			this.kryptonButtonSaveOnlineDatabase.Name = "kryptonButtonSaveOnlineDatabase";
			this.kryptonButtonSaveOnlineDatabase.Size = new System.Drawing.Size(254, 33);
			this.kryptonButtonSaveOnlineDatabase.TabIndex = 4;
			this.toolTip.SetToolTip(this.kryptonButtonSaveOnlineDatabase, "Online-Datenbank speichern");
			this.kryptonButtonSaveOnlineDatabase.Values.Image = global::EXO_DB.Properties.Resources.database_save;
			this.kryptonButtonSaveOnlineDatabase.Values.Text = "Online-Datenbank speichern";
			this.kryptonButtonSaveOnlineDatabase.Click += new System.EventHandler(this.KryptonButtonSaveOnlineDatabase_Click);
			this.kryptonButtonSaveOnlineDatabase.Enter += new System.EventHandler(this.KryptonButtonSaveOnlineDatabase_Enter);
			this.kryptonButtonSaveOnlineDatabase.Leave += new System.EventHandler(this.KryptonButtonSaveOnlineDatabase_Leave);
			this.kryptonButtonSaveOnlineDatabase.MouseEnter += new System.EventHandler(this.KryptonButtonSaveOnlineDatabase_MouseEnter);
			this.kryptonButtonSaveOnlineDatabase.MouseLeave += new System.EventHandler(this.KryptonButtonSaveOnlineDatabase_MouseLeave);
			// 
			// toolStrip
			// 
			this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInformation});
			this.toolStrip.Location = new System.Drawing.Point(3, 24);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(35, 25);
			this.toolStrip.TabIndex = 1;
			this.toolStrip.Text = "toolStrip1";
			// 
			// toolStripButtonInformation
			// 
			this.toolStripButtonInformation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonInformation.Image = global::EXO_DB.Properties.Resources.information;
			this.toolStripButtonInformation.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonInformation.Name = "toolStripButtonInformation";
			this.toolStripButtonInformation.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonInformation.Text = "toolStripButton1";
			this.toolStripButtonInformation.Click += new System.EventHandler(this.ToolStripButtonInformation_Click);
			// 
			// menuStrip
			// 
			this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemHelp});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(784, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// toolStripMenuItemFile
			// 
			this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripMenuItemExit});
			this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
			this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
			this.toolStripMenuItemFile.Text = "&File";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(89, 6);
			// 
			// toolStripMenuItemExit
			// 
			this.toolStripMenuItemExit.Image = global::EXO_DB.Properties.Resources.door_in;
			this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
			this.toolStripMenuItemExit.Size = new System.Drawing.Size(92, 22);
			this.toolStripMenuItemExit.Text = "E&xit";
			this.toolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
			// 
			// toolStripMenuItemHelp
			// 
			this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemInfo});
			this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
			this.toolStripMenuItemHelp.Size = new System.Drawing.Size(44, 20);
			this.toolStripMenuItemHelp.Text = "&Help";
			// 
			// toolStripMenuItemInfo
			// 
			this.toolStripMenuItemInfo.Image = global::EXO_DB.Properties.Resources.information;
			this.toolStripMenuItemInfo.Name = "toolStripMenuItemInfo";
			this.toolStripMenuItemInfo.Size = new System.Drawing.Size(137, 22);
			this.toolStripMenuItemInfo.Text = "&Information";
			this.toolStripMenuItemInfo.Click += new System.EventHandler(this.ToolStripMenuItemInfo_Click);
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(784, 346);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(784, 371);
			this.toolStripContainer1.TabIndex = 3;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer2
			// 
			// 
			// toolStripContainer2.BottomToolStripPanel
			// 
			this.toolStripContainer2.BottomToolStripPanel.Controls.Add(this.statusStrip);
			// 
			// toolStripContainer2.ContentPanel
			// 
			this.toolStripContainer2.ContentPanel.AutoScroll = true;
			this.toolStripContainer2.ContentPanel.Controls.Add(this.kryptonPanel);
			this.toolStripContainer2.ContentPanel.Controls.Add(this.toolStripContainer1);
			this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(784, 371);
			this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer2.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer2.Name = "toolStripContainer2";
			this.toolStripContainer2.Size = new System.Drawing.Size(784, 442);
			this.toolStripContainer2.TabIndex = 3;
			this.toolStripContainer2.Text = "toolStripContainer2";
			// 
			// toolStripContainer2.TopToolStripPanel
			// 
			this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.menuStrip);
			this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.toolStrip);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 442);
			this.Controls.Add(this.toolStripContainer2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Exo-DB";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
			this.kryptonPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator)).EndInit();
			this.kryptonNavigator.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.kryptonPageLoadDatabase)).EndInit();
			this.kryptonPageLoadDatabase.ResumeLayout(false);
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.toolStripContainer2.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer2.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer2.ContentPanel.ResumeLayout(false);
			this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer2.TopToolStripPanel.PerformLayout();
			this.toolStripContainer2.ResumeLayout(false);
			this.toolStripContainer2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
		private ComponentFactory.Krypton.Docking.KryptonDockingManager kryptonDockingManager;
		private System.Windows.Forms.StatusStrip statusStrip;
		private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton toolStripButtonInformation;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
		private System.Windows.Forms.ToolStripContainer toolStripContainer2;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInfo;
		private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator;
		private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPageLoadDatabase;
		private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonLoadInternalDatabase;
		private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonLoadExternalDatabase;
		private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonLoadOnlineDatabase;
		private System.Windows.Forms.ProgressBar progressBarLoadingDatabase;
		private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabelStatusOfProgressingDatabase;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonSaveInternalDatabase;
		private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonSaveOnlineDatabase;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
	}
}

