using System;
using System.Text.Json;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic;
namespace HaloWorkshopManager
{
    public partial class Form1 : Form
    {
        // Stores the filepath to the Steam Workshop's mods
        public string selectedModName;
        public static string modsPath, steamDir, toolsPath;
        public List<ModInfo> modInfo;
        public ModInfo selectedMod;
        public Form1()
        {
            InitializeComponent();
            // Default directory of MCC's workshop content
            modsPath = "C:\\Program Files (x86)\\Steam\\steamapps\\workshop\\content\\976730";
            steamDir = "C:\\Program Files (x86)\\Steam\\steam.exe";
            toolsPath = "C:\\Program Files (x86)\\Steam\\steamapps\\common";
            bool configRead = true;
            FileStreamOptions ops = new FileStreamOptions();
            ops.Mode = FileMode.OpenOrCreate;
            StreamReader config = new StreamReader(@"config.txt", ops);
            string[] configLines = new string[3];
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    configLines[i] = config.ReadLine();
                }
            }
            catch
            {
                configRead = false;
            }
            if (configRead)
            {
                if (String.IsNullOrWhiteSpace(configLines[0]) || String.IsNullOrWhiteSpace(configLines[1]) || String.IsNullOrWhiteSpace(configLines[2]))
                {
                    configRead = false;
                }
            }
            if (configRead)
            {
                modsPath = configLines[0];
                steamDir = configLines[1];
                toolsPath = configLines[2];
            }
            config.Close();

            modInfo = new List<ModInfo>();
            selectedModName = "";
            hCeButton.Image = new Bitmap(hCeButton.Image, new Size(48, 27));
            h2Button.Image = new Bitmap(h2Button.Image, new Size(53, 30));
            h3Button.Image = new Bitmap(h3Button.Image, new Size(53, 30));
            odstButton.Image = new Bitmap(odstButton.Image, new Size(66, 37));
            reachButton.Image = new Bitmap(reachButton.Image, new Size(72, 36));
            h4Button.Image = new Bitmap(h4Button.Image, new Size(53, 30));
            h2aButton.Image = new Bitmap(h2aButton.Image, new Size(53, 30));
            ChangeInfoVisibility(false);
            RefreshWindow(true);
        }
        /// <summary>
        /// Refreshes options on the right side of the window. Returns the number of mods in the directory BEFORE being filtered
        /// </summary>
        private int RefreshOptions(bool full)
        {
            modInfo.Clear();
            int count = 0;
            foreach (string mod in Directory.EnumerateDirectories(modsPath, "", SearchOption.TopDirectoryOnly))
            {
                try
                {
                    ModInfo m = new ModInfo(mod, full);
                    count++;
                    if (FilterCheck(m))
                    {
                        modInfo.Add(m);
                        mods.Items.Add(m.title);
                    }
                }
                catch
                {
                    // TODO: Add console output for failure
                }
            }
            return count;
        }
        /// <summary>
        /// Refreshes all components with correct information
        /// </summary>
        public void RefreshWindow(bool full)
        {
            // ListView of mods
            mods.Items.Clear();
            int count = RefreshOptions(full);
            modCount.Text = "" + mods.Items.Count + " Mods";
            if (full)
            {
                long size = 0;
                foreach (ModInfo m in modInfo)
                {
                    size += m.size;
                }
                totalModSize.Text = "Size: " + Math.Round(size / Math.Pow(1024, 3), 2) + "GB";
            }

            // Centering controls
            modName.Location = new Point(490 - modName.Width / 2, modName.Location.Y);
            modVersion.Location = new Point(490 - modVersion.Width / 2, modVersion.Location.Y);
            modSize.Location = new Point(490 - modSize.Width / 2, modSize.Location.Y);
            modId.Location = new Point(490 - modId.Width / 2, modId.Location.Y);
            guid.Location = new Point(490 - guid.Width / 2, guid.Location.Y);

            // Visibility
            if (mapsListView.CheckedItems.Count == 0)
            {
                mapInfoButton.Enabled = false;
            }
            else
            {
                mapInfoButton.Enabled = true;
            }

            // Empty check
            emptyLabel.Visible = modInfo.Count == 0;
            if (count > 0)
            {
                emptyLabel.Text = "Oops! No mods apply to these filters!";
            }
            else
            {
                emptyLabel.Text = "Looking pretty empty here...\nIs this the right workshop directory?";
            }
        }
        /// <summary>
        /// Checks if the provided mod should be displayed with the currently selected filters
        /// </summary>
        /// <param name="info">The mod to check</param>
        public bool FilterCheck(ModInfo info)
        {
            bool toReturn = false;

            // Game filters
            switch (info.game)
            {
                case "Halo1":
                    if (hCeButton.Checked)
                    {
                        toReturn = true;
                    }
                    break;
                case "Halo2":
                    if (h2Button.Checked)
                    {
                        toReturn = true;
                    }
                    break;
                case "Halo3":
                    if (h3Button.Checked)
                    {
                        toReturn = true;
                    }
                    break;
                case "Halo3ODST":
                    if (odstButton.Checked)
                    {
                        toReturn = true;
                    }
                    break;
                case "HaloReach":
                    if (reachButton.Checked)
                    {
                        toReturn = true;
                    }
                    break;
                case "Halo4":
                    if (h4Button.Checked)
                    {
                        toReturn = true;
                    }
                    break;
                case "Halo2A":
                    if (h2aButton.Checked)
                    {
                        toReturn = true;
                    }
                    break;
            }

            // Mode filters
            if (modeFilterBox.Items[modeFilterBox.SelectedIndex] == "Campaign")
            {
                if (info.campaignMaps.Length == 0)
                {
                    toReturn = false;
                }
            }
            else if (modeFilterBox.Items[modeFilterBox.SelectedIndex] == "Multiplayer")
            {
                if (info.multiMaps.Length == 0)
                {
                    toReturn = false;
                }
            }
            else if (modeFilterBox.Items[modeFilterBox.SelectedIndex] == "Firefight")
            {
                if (info.firefightMaps.Length == 0)
                {
                    toReturn = false;
                }
            }

            return toReturn;
        }
        /// <summary>
        /// Shows or hides the mod info on the right of the window
        /// </summary>
        public void ChangeInfoVisibility(bool visible)
        {
            modName.Visible = visible;
            modVersion.Visible = visible;
            mapsHeaderLabel.Visible = visible;
            mapsListView.Visible = visible;
            modSize.Visible = visible;
            modId.Visible = visible;
            mapInfoButton.Visible = visible;
            guid.Visible = visible;
            showDescriptionButton.Visible = visible;
            openModFolderButton.Visible = visible;
            backupModButton.Visible = visible;
            deleteModButton.Visible = visible;
            backUpCurrentModToolStripMenuItem.Enabled = visible;
        }

        /// <summary>
        /// Saves to the config file
        /// </summary>
        public static void SaveConfigFile()
        {
            StreamWriter writer = new StreamWriter("config.txt");
            writer.WriteLine(modsPath);
            writer.WriteLine(steamDir);
            writer.WriteLine(toolsPath);
            writer.Close();
        }

        private void openModManifestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modDirectoryDialog.ShowDialog() == DialogResult.OK)
            {
                modsPath = modDirectoryDialog.SelectedPath;
                RefreshWindow(true);
                SaveConfigFile();
            }
        }

        // When more info for each map will be shown
        private void mapInfoButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem map in mapsListView.CheckedItems)
            {
                string folder = "campaign";
                foreach (string s in selectedMod.multiMaps)
                {
                    if (s == map.Text)
                    {
                        folder = "multiplayer";
                    }
                }
                foreach (string s in selectedMod.firefightMaps)
                {
                    if (s == map.Text)
                    {
                        folder = "firefight";
                    }
                }
                MapInfoForm mapInfoForm = new MapInfoForm(modsPath + "\\" + modId.Text.Replace("Steam Workshop ID: ", "") + "\\" + folder + "\\" + map.Text + ".json", modsPath + "\\" + modId.Text.Replace("Steam Workshop ID: ", ""));
                mapInfoForm.Show();
            }

            // Unchecking maps
            foreach (ListViewItem item in mapsListView.Items)
            {
                item.Checked = false;
            }
        }

        // When the description is shown
        private void showDescriptionButton_Click(object sender, EventArgs e)
        {
            TextboxForm form = new TextboxForm(selectedMod.description, "Desciption");
            form.Show();
        }

        // When a map is checked
        private void mapsListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            RefreshWindow(false);
        }

        // Closing
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Refresh
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshWindow(true);
        }

        private void hCeButton_Click(object sender, EventArgs e)
        {
            RefreshWindow(true);
        }

        private void hCeButton_CheckedChanged(object sender, EventArgs e)
        {
            RefreshWindow(true);
        }

        private void h2Button_CheckedChanged(object sender, EventArgs e)
        {
            RefreshWindow(true);
        }

        private void h3Button_CheckedChanged(object sender, EventArgs e)
        {
            RefreshWindow(true);
        }

        private void odstButton_CheckedChanged(object sender, EventArgs e)
        {
            RefreshWindow(true);
        }

        private void reachButton_CheckedChanged(object sender, EventArgs e)
        {
            RefreshWindow(true);
        }

        private void h4Button_CheckedChanged(object sender, EventArgs e)
        {
            RefreshWindow(true);
        }

        private void h2aButton_CheckedChanged(object sender, EventArgs e)
        {
            RefreshWindow(true);
        }

        private void modeFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshWindow(true);
        }

        // Deletes the entire mod directory, making Steam reinstall it when MCC is next launched
        private void FullDelete(string modPath)
        {
            foreach (string file in Directory.GetFiles(modPath, "", SearchOption.AllDirectories))
            {
                File.Delete(file);
            }
            Directory.Delete(modPath, true);
        }

        // Opens an explorer window to the selected mod
        private void openModFolderButton_Click(object sender, EventArgs e)
        {
            if (selectedMod.installed)
            {
                Process.Start("explorer.exe", modsPath + "\\" + selectedMod.workshopId);
            }
            else
            {
                DialogResult result = MessageBox.Show("Note: This will temporarily open the Steam console, and the command to reinstall the mod will be copied to your clipboard for you to paste into the console. Otherwise, you will have to unsubscribe and resubscribe to the mod in order for Steam to reinstall it. " + Environment.NewLine + "This will delete the entire mod directory. Until reinstallation through Steam, the mod will disappear from Kangaroo.", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    FullDelete(modsPath + "\\" + selectedMod.workshopId);
                    Process.Start("explorer.exe", "steam://open/console");
                    new Microsoft.VisualBasic.Devices.Computer().Clipboard.SetText("workshop_download_item 976730 " + selectedMod.workshopId);
                    ChangeInfoVisibility(false);
                    RefreshWindow(false);
                }
            }
        }

        /// <summary>
        /// Backs up a mod
        /// </summary>
        /// <param name="oldDirectory">The original mod directory</param>
        /// <param name="newDirectory">The directory to copy the mod to</param>
        private void BackUp(string oldDirectory, string newDirectory)
        {
            new Microsoft.VisualBasic.Devices.Computer().FileSystem.CopyDirectory(oldDirectory, newDirectory);
        }

        // Backing up a mod
        private void backupModButton_Click(object sender, EventArgs e)
        {
            if (backUpFolderDialog.ShowDialog() == DialogResult.OK && backUpFolderDialog.SelectedPath != "")
            {
                try
                {
                    BackUp(modsPath + "\\" + selectedMod.workshopId, backUpFolderDialog.SelectedPath);
                }
                catch
                {
                    // TODO: Add console output for failure
                }
            }
        }

        // Deleting a mod
        private void DeleteMod(string modPath)
        {
            if (Directory.Exists(modPath + "\\maps"))
            {
                foreach (string file in Directory.GetFiles(modPath + "\\maps", "", SearchOption.AllDirectories))
                {
                    File.Delete(file);
                }
                Directory.Delete(modPath + "\\maps\\info");
                Directory.Delete(modPath + "\\maps");
            }
            foreach (string file in Directory.GetFiles(modPath))
            {
                FileInfo info = new FileInfo(file);
                if (info.Extension == ".bk2")
                {
                    File.Delete(file);
                }
            }
        }

        // When the delete mod button is clicked
        private void deleteModButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Warning: Deleting this mod CANNOT be undone." + Environment.NewLine + "Are you sure you wish to proceed?" + Environment.NewLine + "(Note: This only deletes the .map and .bk2 files in the mod, to prevent the Steam workshop from automatically reinstalling it)", "Delete " + selectedMod.title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DeleteMod(modsPath + "\\" + selectedMod.workshopId);
                    ChangeInfoVisibility(false);
                }
                catch
                {
                    // TODO: Add console output
                }
            }
        }

        // Clears all filters
        private void clearFiltersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hCeButton.Checked = true;
            h2Button.Checked = true;
            h3Button.Checked = true;
            odstButton.Checked = true;
            reachButton.Checked = true;
            h4Button.Checked = true;
            h2aButton.Checked = true;
            modeFilterBox.Text = "All Modes";
        }

        private void backUpCurrentModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (backUpFolderDialog.ShowDialog() == DialogResult.OK && backUpFolderDialog.SelectedPath != "")
            {
                try
                {
                    BackUp(modsPath + "\\" + selectedMod.workshopId, backUpFolderDialog.SelectedPath);
                }
                catch
                {
                    // TODO: Add console output for failure
                }
            }
        }

        // Backs up all mods
        private void backUpAllModsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (backUpFolderDialog.ShowDialog() == DialogResult.OK && backUpFolderDialog.SelectedPath != "")
            {
                foreach (ModInfo mod in modInfo)
                {
                    try
                    {
                        BackUp(modsPath + "\\" + mod.workshopId, backUpFolderDialog.SelectedPath + "\\" + mod.workshopId);
                    }
                    catch
                    {
                        // TODO: Add console output for failure
                    }
                }
            }
        }

        // About window
        private void aboutKangarooToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();
        }

        // Restores a backup
        private void restoreBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (restoreBackupDialog.ShowDialog() == DialogResult.OK && restoreBackupDialog.SelectedPath != "")
            {
                try
                {
                    new Microsoft.VisualBasic.Devices.Computer().FileSystem.CopyDirectory(restoreBackupDialog.SelectedPath, modsPath + "\\" + selectedMod.workshopId);
                    ChangeInfoVisibility(false);
                }
                catch
                {
                    // TODO: Add console output
                }
            }
        }

        // Opens the Mod Tools Launcher
        private void openModToolsLauncherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolsForm toolsForm = new ToolsForm();
            toolsForm.Show();
        }

        // GitHub
        private void visitGitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo("https://github.com/Littleozzz10/Kangaroo");
            info.UseShellExecute = true;
            Process.Start(info);
        }

        // Editing directories
        private void editDirectoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectoryForm dirs = new DirectoryForm();
            dirs.Show();
        }

        // When a mod is selected
        private void mods_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeInfoVisibility(true);
            RefreshOptions(false);
            if (mods.SelectedItems.Count > 0)
            {
                // Header
                selectedModName = mods.SelectedItems[0].Text;
                modName.Text = selectedModName;
                foreach (ModInfo i in modInfo)
                {
                    if (i.title == selectedModName)
                    {
                        selectedMod = i;
                    }
                }
                modVersion.Text = "Version: " + selectedMod.majorVersion + "." + selectedMod.minorVersion + "." + selectedMod.patch + " (Engine: " + selectedMod.game + ")";

                // Maps
                mapsListView.Items.Clear();
                foreach (string map in selectedMod.multiMaps)
                {
                    mapsListView.Items.Add(map);
                }
                foreach (string map in selectedMod.firefightMaps)
                {
                    mapsListView.Items.Add(map);
                }
                foreach (string map in selectedMod.campaignMaps)
                {
                    mapsListView.Items.Add(map);
                }

                // Size and Ids
                long size = 0;
                foreach (string file in Directory.EnumerateFiles(modsPath + "\\" + selectedMod.workshopId, "", SearchOption.AllDirectories))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    size += fileInfo.Length;
                }
                modSize.Text = "Mod Size: " + Math.Round((size / Math.Pow(1024, 2)), 2) + " MB";
                modId.Text = "Steam Workshop ID: " + selectedMod.workshopId;
                guid.Text = "GUID: " + selectedMod.guid;

                //Installation status
                if (selectedMod.installed)
                {
                    openModFolderButton.Text = "Open Mod Folder in New Window";
                    backupModButton.Enabled = true;
                    deleteModButton.Enabled = true;
                }
                else
                {
                    openModFolderButton.Text = "Install Mod";
                    backupModButton.Enabled = false;
                    deleteModButton.Enabled = false;
                }
            }
            RefreshWindow(false);
        }
    }
}