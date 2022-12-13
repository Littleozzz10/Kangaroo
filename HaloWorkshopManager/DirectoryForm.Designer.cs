namespace HaloWorkshopManager
{
    partial class DirectoryForm
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
            this.steamDirBox = new System.Windows.Forms.TextBox();
            this.steamDirLabel = new System.Windows.Forms.Label();
            this.steamDirBrowseButton = new System.Windows.Forms.Button();
            this.steamExeDialog = new System.Windows.Forms.OpenFileDialog();
            this.modTools = new System.Windows.Forms.Label();
            this.modToolsDir = new System.Windows.Forms.TextBox();
            this.modToolsBrowseButton = new System.Windows.Forms.Button();
            this.modToolsDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.savePathsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // steamDirBox
            // 
            this.steamDirBox.Location = new System.Drawing.Point(86, 12);
            this.steamDirBox.Name = "steamDirBox";
            this.steamDirBox.Size = new System.Drawing.Size(275, 23);
            this.steamDirBox.TabIndex = 0;
            // 
            // steamDirLabel
            // 
            this.steamDirLabel.AutoSize = true;
            this.steamDirLabel.Location = new System.Drawing.Point(12, 15);
            this.steamDirLabel.Name = "steamDirLabel";
            this.steamDirLabel.Size = new System.Drawing.Size(43, 15);
            this.steamDirLabel.TabIndex = 1;
            this.steamDirLabel.Text = "Steam:";
            // 
            // steamDirBrowseButton
            // 
            this.steamDirBrowseButton.Location = new System.Drawing.Point(367, 12);
            this.steamDirBrowseButton.Name = "steamDirBrowseButton";
            this.steamDirBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.steamDirBrowseButton.TabIndex = 2;
            this.steamDirBrowseButton.Text = "Browse";
            this.steamDirBrowseButton.UseVisualStyleBackColor = true;
            this.steamDirBrowseButton.Click += new System.EventHandler(this.steamDirBrowseButton_Click);
            // 
            // steamExeDialog
            // 
            this.steamExeDialog.Filter = "Executable|*.exe";
            // 
            // modTools
            // 
            this.modTools.AutoSize = true;
            this.modTools.Location = new System.Drawing.Point(12, 55);
            this.modTools.Name = "modTools";
            this.modTools.Size = new System.Drawing.Size(65, 15);
            this.modTools.TabIndex = 3;
            this.modTools.Text = "Mod Tools:";
            // 
            // modToolsDir
            // 
            this.modToolsDir.Location = new System.Drawing.Point(86, 52);
            this.modToolsDir.Name = "modToolsDir";
            this.modToolsDir.Size = new System.Drawing.Size(275, 23);
            this.modToolsDir.TabIndex = 4;
            // 
            // modToolsBrowseButton
            // 
            this.modToolsBrowseButton.Location = new System.Drawing.Point(367, 55);
            this.modToolsBrowseButton.Name = "modToolsBrowseButton";
            this.modToolsBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.modToolsBrowseButton.TabIndex = 5;
            this.modToolsBrowseButton.Text = "Browse";
            this.modToolsBrowseButton.UseVisualStyleBackColor = true;
            this.modToolsBrowseButton.Click += new System.EventHandler(this.modToolsBrowseButton_Click);
            // 
            // modToolsDialog
            // 
            this.modToolsDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // savePathsButton
            // 
            this.savePathsButton.Location = new System.Drawing.Point(183, 87);
            this.savePathsButton.Name = "savePathsButton";
            this.savePathsButton.Size = new System.Drawing.Size(75, 23);
            this.savePathsButton.TabIndex = 6;
            this.savePathsButton.Text = "Save Paths";
            this.savePathsButton.UseVisualStyleBackColor = true;
            this.savePathsButton.Click += new System.EventHandler(this.savePathsButton_Click);
            // 
            // DirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 122);
            this.Controls.Add(this.savePathsButton);
            this.Controls.Add(this.modToolsBrowseButton);
            this.Controls.Add(this.modToolsDir);
            this.Controls.Add(this.modTools);
            this.Controls.Add(this.steamDirBrowseButton);
            this.Controls.Add(this.steamDirLabel);
            this.Controls.Add(this.steamDirBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(469, 161);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(469, 161);
            this.Name = "DirectoryForm";
            this.ShowIcon = false;
            this.Text = "Edit Directories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox steamDirBox;
        private Label steamDirLabel;
        private Button steamDirBrowseButton;
        private OpenFileDialog steamExeDialog;
        private Label modTools;
        private TextBox modToolsDir;
        private Button modToolsBrowseButton;
        private FolderBrowserDialog modToolsDialog;
        private Button savePathsButton;
    }
}