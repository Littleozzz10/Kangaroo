using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Data;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace HaloWorkshopManager
{
    /// <summary>
    /// Shows more detailed information about a map
    /// </summary>
    public partial class MapInfoForm : Form
    {
        private JsonElement root;
        private string modPath;
        public MapInfoForm(string mapPath, string modPath)
        {
            InitializeComponent();
            try
            {
                StreamReader reader = new StreamReader(mapPath);
                JsonDocument doc = JsonDocument.Parse(reader.ReadToEnd());
                root = doc.RootElement;
                mapName.Text = root.GetProperty("Title").GetProperty("Neutral").ToString();
                Text = mapName.Text;
                scenario.Text = "Scenario: " + root.GetProperty("ScenarioFile").ToString();
                mapId.Text = "GUID: " + root.GetProperty("MapGuid").ToString();
                largeImagePath.Text = "Large Image: " + root.GetProperty("Images").GetProperty("Large").ToString();
                //mapSize.Text = "Map Size: " + Math.Round((double)new FileInfo(modPath + "\\maps\\" + mapName.Text).Length, 2) + " MB";
                mapSize.Visible = false;
                string thumbPath = root.GetProperty("Images").GetProperty("Thumbnail").ToString();
                if (thumbPath != "")
                {
                    thumbnailPath.Text = "Thumbnail: " + thumbPath;
                }
                else
                {
                    thumbnailPath.Text = "Thumbnail: [None]";
                    viewThumbnailButton.Enabled = false;
                }
                string loadScreenPath = root.GetProperty("Images").GetProperty("LoadingScreen").ToString();
                if (loadScreenPath != "")
                {
                    loadingScreenPath.Text = "Loading Screen: " + loadScreenPath;
                }
                else
                {
                    loadingScreenPath.Text = "Loading Screen: [None]";
                    viewLoadScreenButton.Enabled = false;
                }
                string largePath = root.GetProperty("Images").GetProperty("Large").ToString();
                if (largePath != "")
                {
                    largeImagePath.Text = "Large Image: " + largePath;
                }
                else
                {
                    largeImagePath.Text = "Large Image: [None]";
                    viewLargeButton.Enabled = false;
                }
                string topPath = root.GetProperty("Images").GetProperty("TopDown").ToString();
                if (topPath != "")
                {
                    topDownPath.Text = "Top-Down: " + topPath;
                }
                else
                {
                    topDownPath.Text = "Top-Down: [None]";
                    viewTopDownButton.Enabled = false;
                }
                descriptionBox.Text = root.GetProperty("Description").GetProperty("Neutral").ToString();
                mapThumbnail.Image = Image.FromFile(modPath + "\\" + root.GetProperty("Images").GetProperty("Thumbnail").ToString());
                this.modPath = modPath;
            }
            catch
            {

            }
        }

        // Viewing thumbnail
        private void viewThumbnailButton_Click(object sender, EventArgs e)
        {
            PictureForm picture = new PictureForm(Image.FromFile(modPath + "\\" + root.GetProperty("Images").GetProperty("Thumbnail").ToString()), "Thumbnail");
            picture.Show();
        }

        // Viewing large image
        private void viewLargeButton_Click(object sender, EventArgs e)
        {
            PictureForm picture = new PictureForm(Image.FromFile(modPath + "\\" + root.GetProperty("Images").GetProperty("Large").ToString()), "Large Image");
            picture.Show();
        }

        // Viewing loading screen
        private void viewLoadScreenButton_Click(object sender, EventArgs e)
        {
            PictureForm picture = new PictureForm(Image.FromFile(modPath + "\\" + root.GetProperty("Images").GetProperty("LoadingScreen").ToString()), "Loading Screen");
            picture.Show();
        }

        // Viewing top down image
        private void viewTopDownButton_Click(object sender, EventArgs e)
        {
            PictureForm picture = new PictureForm(Image.FromFile(modPath + "\\" + root.GetProperty("Images").GetProperty("TopDown").ToString()), "Top-Down");
            picture.Show();
        }
    }
}
