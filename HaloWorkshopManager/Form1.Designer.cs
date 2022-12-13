namespace HaloWorkshopManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openModManifestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDirectoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openModToolsLauncherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpCurrentModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpAllModsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutKangarooToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitGitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mods = new System.Windows.Forms.ListView();
            this.modDirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.modName = new System.Windows.Forms.Label();
            this.modVersion = new System.Windows.Forms.Label();
            this.mapsListView = new System.Windows.Forms.ListView();
            this.mapsHeaderLabel = new System.Windows.Forms.Label();
            this.modSize = new System.Windows.Forms.Label();
            this.modId = new System.Windows.Forms.Label();
            this.mapInfoButton = new System.Windows.Forms.Button();
            this.guid = new System.Windows.Forms.Label();
            this.showDescriptionButton = new System.Windows.Forms.Button();
            this.hCeButton = new System.Windows.Forms.CheckBox();
            this.h2Button = new System.Windows.Forms.CheckBox();
            this.h3Button = new System.Windows.Forms.CheckBox();
            this.odstButton = new System.Windows.Forms.CheckBox();
            this.reachButton = new System.Windows.Forms.CheckBox();
            this.h4Button = new System.Windows.Forms.CheckBox();
            this.h2aButton = new System.Windows.Forms.CheckBox();
            this.modeFilterBox = new System.Windows.Forms.ComboBox();
            this.openModFolderButton = new System.Windows.Forms.Button();
            this.backupModButton = new System.Windows.Forms.Button();
            this.deleteModButton = new System.Windows.Forms.Button();
            this.backUpFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.restoreBackupDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.modCount = new System.Windows.Forms.Label();
            this.totalModSize = new System.Windows.Forms.Label();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.emptyLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(654, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openModManifestToolStripMenuItem,
            this.editDirectoriesToolStripMenuItem,
            this.openModToolsLauncherToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openModManifestToolStripMenuItem
            // 
            this.openModManifestToolStripMenuItem.Name = "openModManifestToolStripMenuItem";
            this.openModManifestToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openModManifestToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.openModManifestToolStripMenuItem.Text = "Open Workshop Directory...";
            this.openModManifestToolStripMenuItem.ToolTipText = "Open the directory where MCC workshop content is saved";
            this.openModManifestToolStripMenuItem.Click += new System.EventHandler(this.openModManifestToolStripMenuItem_Click);
            // 
            // editDirectoriesToolStripMenuItem
            // 
            this.editDirectoriesToolStripMenuItem.Name = "editDirectoriesToolStripMenuItem";
            this.editDirectoriesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.editDirectoriesToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.editDirectoriesToolStripMenuItem.Text = "Edit Directories...";
            this.editDirectoriesToolStripMenuItem.ToolTipText = "Edit and save directories";
            this.editDirectoriesToolStripMenuItem.Click += new System.EventHandler(this.editDirectoriesToolStripMenuItem_Click);
            // 
            // openModToolsLauncherToolStripMenuItem
            // 
            this.openModToolsLauncherToolStripMenuItem.Name = "openModToolsLauncherToolStripMenuItem";
            this.openModToolsLauncherToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.openModToolsLauncherToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.openModToolsLauncherToolStripMenuItem.Text = "Open Mod Tools Launcher...";
            this.openModToolsLauncherToolStripMenuItem.ToolTipText = "Opens the Kangaroo Mod Tools Launcher";
            this.openModToolsLauncherToolStripMenuItem.Click += new System.EventHandler(this.openModToolsLauncherToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.clearFiltersToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // clearFiltersToolStripMenuItem
            // 
            this.clearFiltersToolStripMenuItem.Name = "clearFiltersToolStripMenuItem";
            this.clearFiltersToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.clearFiltersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearFiltersToolStripMenuItem.Text = "Clear Filters";
            this.clearFiltersToolStripMenuItem.ToolTipText = "Clears all active mod filters";
            this.clearFiltersToolStripMenuItem.Click += new System.EventHandler(this.clearFiltersToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backUpCurrentModToolStripMenuItem,
            this.backUpAllModsToolStripMenuItem,
            this.restoreBackupToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // backUpCurrentModToolStripMenuItem
            // 
            this.backUpCurrentModToolStripMenuItem.Name = "backUpCurrentModToolStripMenuItem";
            this.backUpCurrentModToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backUpCurrentModToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.backUpCurrentModToolStripMenuItem.Text = "Back Up Current Mod...";
            this.backUpCurrentModToolStripMenuItem.ToolTipText = "Back up the currently selected mod";
            this.backUpCurrentModToolStripMenuItem.Click += new System.EventHandler(this.backUpCurrentModToolStripMenuItem_Click);
            // 
            // backUpAllModsToolStripMenuItem
            // 
            this.backUpAllModsToolStripMenuItem.Name = "backUpAllModsToolStripMenuItem";
            this.backUpAllModsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.backUpAllModsToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.backUpAllModsToolStripMenuItem.Text = "Back Up All Mods...";
            this.backUpAllModsToolStripMenuItem.ToolTipText = "Back up all mods under the current filters";
            this.backUpAllModsToolStripMenuItem.Click += new System.EventHandler(this.backUpAllModsToolStripMenuItem_Click);
            // 
            // restoreBackupToolStripMenuItem
            // 
            this.restoreBackupToolStripMenuItem.Name = "restoreBackupToolStripMenuItem";
            this.restoreBackupToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.restoreBackupToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.restoreBackupToolStripMenuItem.Text = "Restore Backup...";
            this.restoreBackupToolStripMenuItem.ToolTipText = "Restore a mod from a backup";
            this.restoreBackupToolStripMenuItem.Click += new System.EventHandler(this.restoreBackupToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutKangarooToolStripMenuItem,
            this.visitGitHubToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutKangarooToolStripMenuItem
            // 
            this.aboutKangarooToolStripMenuItem.Name = "aboutKangarooToolStripMenuItem";
            this.aboutKangarooToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutKangarooToolStripMenuItem.Text = "About Kangaroo...";
            this.aboutKangarooToolStripMenuItem.Click += new System.EventHandler(this.aboutKangarooToolStripMenuItem_Click);
            // 
            // visitGitHubToolStripMenuItem
            // 
            this.visitGitHubToolStripMenuItem.Name = "visitGitHubToolStripMenuItem";
            this.visitGitHubToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visitGitHubToolStripMenuItem.Text = "Visit GitHub...";
            this.visitGitHubToolStripMenuItem.ToolTipText = "Opens Kangaroo\'s GitHub Repository in your default browser";
            this.visitGitHubToolStripMenuItem.Click += new System.EventHandler(this.visitGitHubToolStripMenuItem_Click);
            // 
            // mods
            // 
            this.mods.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.mods.Location = new System.Drawing.Point(12, 103);
            this.mods.MultiSelect = false;
            this.mods.Name = "mods";
            this.mods.Size = new System.Drawing.Size(303, 311);
            this.mods.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.mods.TabIndex = 1;
            this.mods.UseCompatibleStateImageBehavior = false;
            this.mods.View = System.Windows.Forms.View.List;
            this.mods.SelectedIndexChanged += new System.EventHandler(this.mods_SelectedIndexChanged);
            // 
            // modDirectoryDialog
            // 
            this.modDirectoryDialog.Description = "Select the Master Chief Collection\'s workshop folder...";
            this.modDirectoryDialog.UseDescriptionForTitle = true;
            // 
            // modName
            // 
            this.modName.AutoSize = true;
            this.modName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.modName.Location = new System.Drawing.Point(445, 27);
            this.modName.Name = "modName";
            this.modName.Size = new System.Drawing.Size(91, 21);
            this.modName.TabIndex = 2;
            this.modName.Text = "modName";
            // 
            // modVersion
            // 
            this.modVersion.AutoSize = true;
            this.modVersion.Location = new System.Drawing.Point(455, 48);
            this.modVersion.Name = "modVersion";
            this.modVersion.Size = new System.Drawing.Size(70, 15);
            this.modVersion.TabIndex = 3;
            this.modVersion.Text = "modVersion";
            // 
            // mapsListView
            // 
            this.mapsListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.mapsListView.CheckBoxes = true;
            this.mapsListView.Location = new System.Drawing.Point(372, 104);
            this.mapsListView.Name = "mapsListView";
            this.mapsListView.Size = new System.Drawing.Size(232, 148);
            this.mapsListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.mapsListView.TabIndex = 4;
            this.mapsListView.UseCompatibleStateImageBehavior = false;
            this.mapsListView.View = System.Windows.Forms.View.List;
            this.mapsListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.mapsListView_ItemChecked);
            // 
            // mapsHeaderLabel
            // 
            this.mapsHeaderLabel.AutoSize = true;
            this.mapsHeaderLabel.Location = new System.Drawing.Point(372, 86);
            this.mapsHeaderLabel.Name = "mapsHeaderLabel";
            this.mapsHeaderLabel.Size = new System.Drawing.Size(39, 15);
            this.mapsHeaderLabel.TabIndex = 5;
            this.mapsHeaderLabel.Text = "Maps:";
            // 
            // modSize
            // 
            this.modSize.AutoSize = true;
            this.modSize.Location = new System.Drawing.Point(464, 284);
            this.modSize.Name = "modSize";
            this.modSize.Size = new System.Drawing.Size(52, 15);
            this.modSize.TabIndex = 6;
            this.modSize.Text = "modSize";
            // 
            // modId
            // 
            this.modId.AutoSize = true;
            this.modId.Location = new System.Drawing.Point(474, 299);
            this.modId.Name = "modId";
            this.modId.Size = new System.Drawing.Size(42, 15);
            this.modId.TabIndex = 7;
            this.modId.Text = "modId";
            // 
            // mapInfoButton
            // 
            this.mapInfoButton.Location = new System.Drawing.Point(399, 258);
            this.mapInfoButton.Name = "mapInfoButton";
            this.mapInfoButton.Size = new System.Drawing.Size(176, 23);
            this.mapInfoButton.TabIndex = 8;
            this.mapInfoButton.Text = "View Selected Map Info";
            this.mapInfoButton.UseVisualStyleBackColor = true;
            this.mapInfoButton.Click += new System.EventHandler(this.mapInfoButton_Click);
            // 
            // guid
            // 
            this.guid.AutoSize = true;
            this.guid.Location = new System.Drawing.Point(474, 314);
            this.guid.Name = "guid";
            this.guid.Size = new System.Drawing.Size(31, 15);
            this.guid.TabIndex = 9;
            this.guid.Text = "guid";
            // 
            // showDescriptionButton
            // 
            this.showDescriptionButton.Location = new System.Drawing.Point(506, 78);
            this.showDescriptionButton.Name = "showDescriptionButton";
            this.showDescriptionButton.Size = new System.Drawing.Size(136, 23);
            this.showDescriptionButton.TabIndex = 10;
            this.showDescriptionButton.Text = "Show Mod Description";
            this.showDescriptionButton.UseVisualStyleBackColor = true;
            this.showDescriptionButton.Click += new System.EventHandler(this.showDescriptionButton_Click);
            // 
            // hCeButton
            // 
            this.hCeButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.hCeButton.Checked = true;
            this.hCeButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hCeButton.Image = global::HaloWorkshopManager.Properties.Resources.mcc1;
            this.hCeButton.Location = new System.Drawing.Point(12, 31);
            this.hCeButton.Name = "hCeButton";
            this.hCeButton.Size = new System.Drawing.Size(36, 36);
            this.hCeButton.TabIndex = 12;
            this.toolTipMain.SetToolTip(this.hCeButton, "Halo: CE");
            this.hCeButton.UseVisualStyleBackColor = true;
            this.hCeButton.CheckedChanged += new System.EventHandler(this.hCeButton_CheckedChanged);
            // 
            // h2Button
            // 
            this.h2Button.Appearance = System.Windows.Forms.Appearance.Button;
            this.h2Button.Checked = true;
            this.h2Button.CheckState = System.Windows.Forms.CheckState.Checked;
            this.h2Button.Image = global::HaloWorkshopManager.Properties.Resources.mcc2c;
            this.h2Button.Location = new System.Drawing.Point(54, 31);
            this.h2Button.Name = "h2Button";
            this.h2Button.Size = new System.Drawing.Size(36, 36);
            this.h2Button.TabIndex = 13;
            this.toolTipMain.SetToolTip(this.h2Button, "Halo 2 Classic");
            this.h2Button.UseVisualStyleBackColor = true;
            this.h2Button.CheckedChanged += new System.EventHandler(this.h2Button_CheckedChanged);
            // 
            // h3Button
            // 
            this.h3Button.Appearance = System.Windows.Forms.Appearance.Button;
            this.h3Button.Checked = true;
            this.h3Button.CheckState = System.Windows.Forms.CheckState.Checked;
            this.h3Button.Image = global::HaloWorkshopManager.Properties.Resources.mcc3;
            this.h3Button.Location = new System.Drawing.Point(96, 31);
            this.h3Button.Name = "h3Button";
            this.h3Button.Size = new System.Drawing.Size(36, 36);
            this.h3Button.TabIndex = 14;
            this.toolTipMain.SetToolTip(this.h3Button, "Halo 3");
            this.h3Button.UseVisualStyleBackColor = true;
            this.h3Button.CheckedChanged += new System.EventHandler(this.h3Button_CheckedChanged);
            // 
            // odstButton
            // 
            this.odstButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.odstButton.Checked = true;
            this.odstButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.odstButton.Image = global::HaloWorkshopManager.Properties.Resources.mccodst;
            this.odstButton.Location = new System.Drawing.Point(138, 31);
            this.odstButton.Name = "odstButton";
            this.odstButton.Size = new System.Drawing.Size(36, 36);
            this.odstButton.TabIndex = 15;
            this.toolTipMain.SetToolTip(this.odstButton, "Halo 3: ODST");
            this.odstButton.UseVisualStyleBackColor = true;
            this.odstButton.CheckedChanged += new System.EventHandler(this.odstButton_CheckedChanged);
            // 
            // reachButton
            // 
            this.reachButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.reachButton.Checked = true;
            this.reachButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.reachButton.Image = global::HaloWorkshopManager.Properties.Resources.mccr;
            this.reachButton.Location = new System.Drawing.Point(180, 31);
            this.reachButton.Name = "reachButton";
            this.reachButton.Size = new System.Drawing.Size(36, 36);
            this.reachButton.TabIndex = 16;
            this.toolTipMain.SetToolTip(this.reachButton, "Halo: Reach");
            this.reachButton.UseVisualStyleBackColor = true;
            this.reachButton.CheckedChanged += new System.EventHandler(this.reachButton_CheckedChanged);
            // 
            // h4Button
            // 
            this.h4Button.Appearance = System.Windows.Forms.Appearance.Button;
            this.h4Button.Checked = true;
            this.h4Button.CheckState = System.Windows.Forms.CheckState.Checked;
            this.h4Button.Image = global::HaloWorkshopManager.Properties.Resources.mcc4;
            this.h4Button.Location = new System.Drawing.Point(222, 31);
            this.h4Button.Name = "h4Button";
            this.h4Button.Size = new System.Drawing.Size(36, 36);
            this.h4Button.TabIndex = 17;
            this.toolTipMain.SetToolTip(this.h4Button, "Halo 4");
            this.h4Button.UseVisualStyleBackColor = true;
            this.h4Button.CheckedChanged += new System.EventHandler(this.h4Button_CheckedChanged);
            // 
            // h2aButton
            // 
            this.h2aButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.h2aButton.Checked = true;
            this.h2aButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.h2aButton.Image = global::HaloWorkshopManager.Properties.Resources.mcc2a;
            this.h2aButton.Location = new System.Drawing.Point(264, 31);
            this.h2aButton.Name = "h2aButton";
            this.h2aButton.Size = new System.Drawing.Size(36, 36);
            this.h2aButton.TabIndex = 18;
            this.toolTipMain.SetToolTip(this.h2aButton, "Halo 2: Anniversary MP");
            this.h2aButton.UseVisualStyleBackColor = true;
            this.h2aButton.CheckedChanged += new System.EventHandler(this.h2aButton_CheckedChanged);
            // 
            // modeFilterBox
            // 
            this.modeFilterBox.FormattingEnabled = true;
            this.modeFilterBox.Items.AddRange(new object[] {
            "All Modes",
            "Campaign",
            "Multiplayer",
            "Firefight"});
            this.modeFilterBox.Location = new System.Drawing.Point(96, 74);
            this.modeFilterBox.Name = "modeFilterBox";
            this.modeFilterBox.Size = new System.Drawing.Size(121, 23);
            this.modeFilterBox.TabIndex = 19;
            this.modeFilterBox.Text = "All Modes";
            this.toolTipMain.SetToolTip(this.modeFilterBox, "Selects the gamemode filter");
            this.modeFilterBox.SelectedIndexChanged += new System.EventHandler(this.modeFilterBox_SelectedIndexChanged);
            // 
            // openModFolderButton
            // 
            this.openModFolderButton.Location = new System.Drawing.Point(321, 334);
            this.openModFolderButton.Name = "openModFolderButton";
            this.openModFolderButton.Size = new System.Drawing.Size(321, 37);
            this.openModFolderButton.TabIndex = 20;
            this.openModFolderButton.Text = "Open Mod Folder in New Window";
            this.openModFolderButton.UseVisualStyleBackColor = true;
            this.openModFolderButton.Click += new System.EventHandler(this.openModFolderButton_Click);
            // 
            // backupModButton
            // 
            this.backupModButton.ForeColor = System.Drawing.Color.Green;
            this.backupModButton.Location = new System.Drawing.Point(321, 377);
            this.backupModButton.Name = "backupModButton";
            this.backupModButton.Size = new System.Drawing.Size(155, 37);
            this.backupModButton.TabIndex = 21;
            this.backupModButton.Text = "Back Up Mod";
            this.toolTipMain.SetToolTip(this.backupModButton, "Back up this mod to a folder");
            this.backupModButton.UseVisualStyleBackColor = true;
            this.backupModButton.Click += new System.EventHandler(this.backupModButton_Click);
            // 
            // deleteModButton
            // 
            this.deleteModButton.ForeColor = System.Drawing.Color.Red;
            this.deleteModButton.Location = new System.Drawing.Point(487, 377);
            this.deleteModButton.Name = "deleteModButton";
            this.deleteModButton.Size = new System.Drawing.Size(155, 37);
            this.deleteModButton.TabIndex = 22;
            this.deleteModButton.Text = "Delete Mod";
            this.toolTipMain.SetToolTip(this.deleteModButton, "Deletes the .map and .bk2 files in the mod");
            this.deleteModButton.UseVisualStyleBackColor = true;
            this.deleteModButton.Click += new System.EventHandler(this.deleteModButton_Click);
            // 
            // backUpFolderDialog
            // 
            this.backUpFolderDialog.Description = "Choose a folder to back up to...";
            this.backUpFolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.backUpFolderDialog.UseDescriptionForTitle = true;
            // 
            // restoreBackupDialog
            // 
            this.restoreBackupDialog.Description = "Choose a backup folder to restore...";
            this.restoreBackupDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.restoreBackupDialog.UseDescriptionForTitle = true;
            // 
            // modCount
            // 
            this.modCount.AutoSize = true;
            this.modCount.Location = new System.Drawing.Point(12, 77);
            this.modCount.Name = "modCount";
            this.modCount.Size = new System.Drawing.Size(65, 15);
            this.modCount.TabIndex = 23;
            this.modCount.Text = "modCount";
            // 
            // totalModSize
            // 
            this.totalModSize.AutoSize = true;
            this.totalModSize.Location = new System.Drawing.Point(239, 78);
            this.totalModSize.Name = "totalModSize";
            this.totalModSize.Size = new System.Drawing.Size(76, 15);
            this.totalModSize.TabIndex = 24;
            this.totalModSize.Text = "totalModSize";
            this.totalModSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // emptyLabel
            // 
            this.emptyLabel.AutoSize = true;
            this.emptyLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.emptyLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emptyLabel.Location = new System.Drawing.Point(44, 237);
            this.emptyLabel.Name = "emptyLabel";
            this.emptyLabel.Size = new System.Drawing.Size(230, 34);
            this.emptyLabel.TabIndex = 25;
            this.emptyLabel.Text = "Looking pretty empty here...\r\nIs this the right workshop directory?";
            this.emptyLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTipMain.SetToolTip(this.emptyLabel, "Check to make sure you\'ve opened the right workshop directory");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 426);
            this.Controls.Add(this.emptyLabel);
            this.Controls.Add(this.totalModSize);
            this.Controls.Add(this.modCount);
            this.Controls.Add(this.deleteModButton);
            this.Controls.Add(this.backupModButton);
            this.Controls.Add(this.openModFolderButton);
            this.Controls.Add(this.modeFilterBox);
            this.Controls.Add(this.h2aButton);
            this.Controls.Add(this.h4Button);
            this.Controls.Add(this.reachButton);
            this.Controls.Add(this.odstButton);
            this.Controls.Add(this.h3Button);
            this.Controls.Add(this.h2Button);
            this.Controls.Add(this.hCeButton);
            this.Controls.Add(this.showDescriptionButton);
            this.Controls.Add(this.guid);
            this.Controls.Add(this.mapInfoButton);
            this.Controls.Add(this.modId);
            this.Controls.Add(this.modSize);
            this.Controls.Add(this.mapsHeaderLabel);
            this.Controls.Add(this.mapsListView);
            this.Controls.Add(this.modVersion);
            this.Controls.Add(this.modName);
            this.Controls.Add(this.mods);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(670, 465);
            this.MinimumSize = new System.Drawing.Size(670, 465);
            this.Name = "Form1";
            this.Text = "Kangaroo - Halo MCC Mod Manager for Steam Workshop";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ListView mods;
        private ToolStripMenuItem openModManifestToolStripMenuItem;
        private FolderBrowserDialog modDirectoryDialog;
        private Label modName;
        private Label modVersion;
        private ListView mapsListView;
        private Label mapsHeaderLabel;
        private Label modSize;
        private Label modId;
        private Button mapInfoButton;
        private Label guid;
        private Button showDescriptionButton;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ToolStripMenuItem clearFiltersToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem backUpCurrentModToolStripMenuItem;
        private ToolStripMenuItem backUpAllModsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutKangarooToolStripMenuItem;
        private ToolStripMenuItem visitGitHubToolStripMenuItem;
        private ToolStripMenuItem restoreBackupToolStripMenuItem;
        private CheckBox hCeButton;
        private CheckBox h2Button;
        private CheckBox h3Button;
        private CheckBox odstButton;
        private CheckBox reachButton;
        private CheckBox h4Button;
        private CheckBox h2aButton;
        private ComboBox modeFilterBox;
        private Button openModFolderButton;
        private Button backupModButton;
        private Button deleteModButton;
        private FolderBrowserDialog backUpFolderDialog;
        private FolderBrowserDialog restoreBackupDialog;
        private Label modCount;
        private Label totalModSize;
        private ToolStripMenuItem editDirectoriesToolStripMenuItem;
        private ToolStripMenuItem openModToolsLauncherToolStripMenuItem;
        private ToolTip toolTipMain;
        private Label emptyLabel;
    }
}