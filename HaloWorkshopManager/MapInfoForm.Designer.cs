namespace HaloWorkshopManager
{
    partial class MapInfoForm
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
            this.mapName = new System.Windows.Forms.Label();
            this.scenario = new System.Windows.Forms.Label();
            this.mapId = new System.Windows.Forms.Label();
            this.largeImagePath = new System.Windows.Forms.Label();
            this.thumbnailPath = new System.Windows.Forms.Label();
            this.loadingScreenPath = new System.Windows.Forms.Label();
            this.topDownPath = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.mapThumbnail = new System.Windows.Forms.PictureBox();
            this.viewThumbnailButton = new System.Windows.Forms.Button();
            this.viewLargeButton = new System.Windows.Forms.Button();
            this.viewLoadScreenButton = new System.Windows.Forms.Button();
            this.viewTopDownButton = new System.Windows.Forms.Button();
            this.mapSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mapThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // mapName
            // 
            this.mapName.AutoSize = true;
            this.mapName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.mapName.Location = new System.Drawing.Point(12, 9);
            this.mapName.Name = "mapName";
            this.mapName.Size = new System.Drawing.Size(68, 17);
            this.mapName.TabIndex = 0;
            this.mapName.Text = "mapName";
            // 
            // scenario
            // 
            this.scenario.AutoSize = true;
            this.scenario.Location = new System.Drawing.Point(12, 36);
            this.scenario.Name = "scenario";
            this.scenario.Size = new System.Drawing.Size(51, 15);
            this.scenario.TabIndex = 1;
            this.scenario.Text = "scenario";
            // 
            // mapId
            // 
            this.mapId.AutoSize = true;
            this.mapId.Location = new System.Drawing.Point(12, 51);
            this.mapId.Name = "mapId";
            this.mapId.Size = new System.Drawing.Size(41, 15);
            this.mapId.TabIndex = 2;
            this.mapId.Text = "mapId";
            // 
            // largeImagePath
            // 
            this.largeImagePath.AutoSize = true;
            this.largeImagePath.Location = new System.Drawing.Point(12, 66);
            this.largeImagePath.Name = "largeImagePath";
            this.largeImagePath.Size = new System.Drawing.Size(90, 15);
            this.largeImagePath.TabIndex = 3;
            this.largeImagePath.Text = "largeImagePath";
            // 
            // thumbnailPath
            // 
            this.thumbnailPath.AutoSize = true;
            this.thumbnailPath.Location = new System.Drawing.Point(12, 81);
            this.thumbnailPath.Name = "thumbnailPath";
            this.thumbnailPath.Size = new System.Drawing.Size(86, 15);
            this.thumbnailPath.TabIndex = 4;
            this.thumbnailPath.Text = "thumbnailPath";
            // 
            // loadingScreenPath
            // 
            this.loadingScreenPath.AutoSize = true;
            this.loadingScreenPath.Location = new System.Drawing.Point(12, 96);
            this.loadingScreenPath.Name = "loadingScreenPath";
            this.loadingScreenPath.Size = new System.Drawing.Size(106, 15);
            this.loadingScreenPath.TabIndex = 5;
            this.loadingScreenPath.Text = "loadingScreenPath";
            // 
            // topDownPath
            // 
            this.topDownPath.AutoSize = true;
            this.topDownPath.Location = new System.Drawing.Point(12, 111);
            this.topDownPath.Name = "topDownPath";
            this.topDownPath.Size = new System.Drawing.Size(80, 15);
            this.topDownPath.TabIndex = 6;
            this.topDownPath.Text = "topDownPath";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(12, 157);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionBox.Size = new System.Drawing.Size(512, 87);
            this.descriptionBox.TabIndex = 7;
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(12, 139);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(70, 15);
            this.descLabel.TabIndex = 8;
            this.descLabel.Text = "Description:";
            // 
            // mapThumbnail
            // 
            this.mapThumbnail.Location = new System.Drawing.Point(348, 27);
            this.mapThumbnail.Name = "mapThumbnail";
            this.mapThumbnail.Size = new System.Drawing.Size(176, 99);
            this.mapThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapThumbnail.TabIndex = 9;
            this.mapThumbnail.TabStop = false;
            // 
            // viewThumbnailButton
            // 
            this.viewThumbnailButton.Location = new System.Drawing.Point(125, 131);
            this.viewThumbnailButton.Name = "viewThumbnailButton";
            this.viewThumbnailButton.Size = new System.Drawing.Size(100, 23);
            this.viewThumbnailButton.TabIndex = 10;
            this.viewThumbnailButton.Text = "View Thumbnail";
            this.viewThumbnailButton.UseVisualStyleBackColor = true;
            this.viewThumbnailButton.Click += new System.EventHandler(this.viewThumbnailButton_Click);
            // 
            // viewLargeButton
            // 
            this.viewLargeButton.Location = new System.Drawing.Point(231, 131);
            this.viewLargeButton.Name = "viewLargeButton";
            this.viewLargeButton.Size = new System.Drawing.Size(75, 23);
            this.viewLargeButton.TabIndex = 11;
            this.viewLargeButton.Text = "View Large";
            this.viewLargeButton.UseVisualStyleBackColor = true;
            this.viewLargeButton.Click += new System.EventHandler(this.viewLargeButton_Click);
            // 
            // viewLoadScreenButton
            // 
            this.viewLoadScreenButton.Location = new System.Drawing.Point(312, 131);
            this.viewLoadScreenButton.Name = "viewLoadScreenButton";
            this.viewLoadScreenButton.Size = new System.Drawing.Size(107, 23);
            this.viewLoadScreenButton.TabIndex = 12;
            this.viewLoadScreenButton.Text = "View Load Screen";
            this.viewLoadScreenButton.UseVisualStyleBackColor = true;
            this.viewLoadScreenButton.Click += new System.EventHandler(this.viewLoadScreenButton_Click);
            // 
            // viewTopDownButton
            // 
            this.viewTopDownButton.Location = new System.Drawing.Point(425, 131);
            this.viewTopDownButton.Name = "viewTopDownButton";
            this.viewTopDownButton.Size = new System.Drawing.Size(99, 23);
            this.viewTopDownButton.TabIndex = 13;
            this.viewTopDownButton.Text = "View Top-Down";
            this.viewTopDownButton.UseVisualStyleBackColor = true;
            this.viewTopDownButton.Click += new System.EventHandler(this.viewTopDownButton_Click);
            // 
            // mapSize
            // 
            this.mapSize.AutoSize = true;
            this.mapSize.Location = new System.Drawing.Point(473, 9);
            this.mapSize.Name = "mapSize";
            this.mapSize.Size = new System.Drawing.Size(51, 15);
            this.mapSize.TabIndex = 14;
            this.mapSize.Text = "mapSize";
            this.mapSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MapInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 253);
            this.Controls.Add(this.mapSize);
            this.Controls.Add(this.viewTopDownButton);
            this.Controls.Add(this.viewLoadScreenButton);
            this.Controls.Add(this.viewLargeButton);
            this.Controls.Add(this.viewThumbnailButton);
            this.Controls.Add(this.mapThumbnail);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.topDownPath);
            this.Controls.Add(this.loadingScreenPath);
            this.Controls.Add(this.thumbnailPath);
            this.Controls.Add(this.largeImagePath);
            this.Controls.Add(this.mapId);
            this.Controls.Add(this.scenario);
            this.Controls.Add(this.mapName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(552, 292);
            this.MinimumSize = new System.Drawing.Size(552, 292);
            this.Name = "MapInfoForm";
            this.ShowIcon = false;
            this.Text = "MapInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.mapThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label mapName;
        private Label scenario;
        private Label mapId;
        private Label largeImagePath;
        private Label thumbnailPath;
        private Label loadingScreenPath;
        private Label topDownPath;
        private TextBox descriptionBox;
        private Label descLabel;
        private PictureBox mapThumbnail;
        private Button viewThumbnailButton;
        private Button viewLargeButton;
        private Button viewLoadScreenButton;
        private Button viewTopDownButton;
        private Label mapSize;
    }
}