using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace HaloWorkshopManager
{
    public partial class ToolsForm : Form
    {
        public Dictionary<string, string> tools;
        public ToolsForm()
        {
            InitializeComponent();
            RefreshFilepaths();
        }
        // Resets filepaths
        private void RefreshFilepaths()
        {
            tools = new Dictionary<string, string>();

            // Halo: CE
            if (Directory.Exists(Form1.toolsPath + "\\HCEEK"))
            {
                tools.Add("HCE", Form1.toolsPath + "\\HCEEK");
                if (File.Exists(Form1.toolsPath + "\\HCEEK\\guerilla.exe"))
                {
                    tools.Add("HCEG", Form1.toolsPath + "\\HCEEK\\guerilla.exe");
                    hcegImage.Image = Icon.ExtractAssociatedIcon(Form1.toolsPath + "\\HCEEK\\guerilla.exe").ToBitmap();
                    hcegImage.Visible = true;
                    hcegLabel.Visible = true;
                }
                else
                {
                    tools.Add("HCEG", "");
                    hcegImage.Visible = false;
                    hcegLabel.Visible = false;
                }
                if (File.Exists(Form1.toolsPath + "\\HCEEK\\sapien.exe"))
                {
                    tools.Add("HCES", Form1.toolsPath + "\\HCEEK\\sapien.exe");
                    hcesImage.Image = Icon.ExtractAssociatedIcon(Form1.toolsPath + "\\HCEEK\\sapien.exe").ToBitmap();
                    hcesImage.Visible = true;
                    hcesLabel.Visible = true;
                }
                else
                {
                    tools.Add("HCES", "");
                    hcesImage.Visible = false;
                    hcesLabel.Visible = false;
                }
                if (File.Exists(Form1.toolsPath + "\\HCEEK\\halo_tag_test.exe"))
                {
                    tools.Add("HCET", Form1.toolsPath + "\\HCEEK\\halo_tag_test.exe");
                    hcetImage.Image = Icon.ExtractAssociatedIcon(Form1.toolsPath + "\\HCEEK\\halo_tag_test.exe").ToBitmap();
                    hcetImage.Visible = true;
                    hcetLabel.Visible = true;
                }
                else
                {
                    tools.Add("HCET", "");
                    hcetImage.Visible = false;
                    hcetLabel.Visible = false;
                }
            }
            else
            {
                tools.Add("HCEG", "");
                hcegImage.Visible = false;
                hcegLabel.Visible = false;
                tools.Add("HCES", "");
                hcesImage.Visible = false;
                hcesLabel.Visible = false;
                tools.Add("HCET", "");
                hcetImage.Visible = false;
                hcetLabel.Visible = false;
            }

            // Halo 2
            if (Directory.Exists(Form1.toolsPath + "\\H2EK"))
            {
                tools.Add("H2", Form1.toolsPath + "\\H2EK");
                if (File.Exists(Form1.toolsPath + "\\H2EK\\guerilla.exe"))
                {
                    tools.Add("H2G", Form1.toolsPath + "\\H2EK\\guerilla.exe");
                    h2gImage.Image = Icon.ExtractAssociatedIcon(Form1.toolsPath + "\\H2EK\\guerilla.exe").ToBitmap();
                    h2gImage.Visible = true;
                    h2gLabel.Visible = true;
                }
                else
                {
                    tools.Add("H2G", "");
                    h2gImage.Visible = false;
                    h2gLabel.Visible = false;
                }
                if (File.Exists(Form1.toolsPath + "\\H2EK\\sapien.exe"))
                {
                    tools.Add("H2S", Form1.toolsPath + "\\H2EK\\sapien.exe");
                    h2sImage.Image = Icon.ExtractAssociatedIcon(Form1.toolsPath + "\\H2EK\\sapien.exe").ToBitmap();
                    h2sImage.Visible = true;
                    h2sLabel.Visible = true;
                }
                else
                {
                    tools.Add("H2S", "");
                    h2sImage.Visible = false;
                    h2sLabel.Visible = false;
                }
                if (File.Exists(Form1.toolsPath + "\\H2EK\\halo2_tag_test.exe"))
                {
                    tools.Add("H2T", Form1.toolsPath + "\\H2EK\\halo2_tag_test.exe");
                    h2tImage.Image = Icon.ExtractAssociatedIcon(Form1.toolsPath + "\\H2EK\\halo2_tag_test.exe").ToBitmap();
                    h2tImage.Visible = true;
                    h2tLabel.Visible = true;
                }
                else
                {
                    tools.Add("H2T", "");
                    h2tImage.Visible = false;
                    h2tLabel.Visible = false;
                }
            }
            else
            {
                tools.Add("H2G", "");
                h2gImage.Visible = false;
                h2gLabel.Visible = false;
                tools.Add("H2S", "");
                h2sImage.Visible = false;
                h2sLabel.Visible = false;
                tools.Add("H2T", "");
                h2tImage.Visible = false;
                h2tLabel.Visible = false;
            }

            // Halo 3
            if (Directory.Exists(Form1.toolsPath + "\\H3EK"))
            {
                tools.Add("H3", Form1.toolsPath + "\\H3EK");
                if (File.Exists(Form1.toolsPath + "\\H3EK\\guerilla.exe"))
                {
                    tools.Add("H3G", Form1.toolsPath + "\\H3EK\\guerilla.exe");
                    h3gImage.Image = Icon.ExtractAssociatedIcon(Form1.toolsPath + "\\H3EK\\guerilla.exe").ToBitmap();
                    h3gImage.Visible = true;
                    h3gLabel.Visible = true;
                }
                else
                {
                    tools.Add("H3G", "");
                    h3gImage.Visible = false;
                    h3gLabel.Visible = false;
                }
                if (File.Exists(Form1.toolsPath + "\\H3EK\\sapien.exe"))
                {
                    tools.Add("H3S", Form1.toolsPath + "\\H3EK\\sapien.exe");
                    h3sImage.Image = Icon.ExtractAssociatedIcon(Form1.toolsPath + "\\H3EK\\sapien.exe").ToBitmap();
                    h3sImage.Visible = true;
                    h3sLabel.Visible = true;
                }
                else
                {
                    tools.Add("H3S", "");
                    h3sImage.Visible = false;
                    h3sLabel.Visible = false;
                }
                if (File.Exists(Form1.toolsPath + "\\H3EK\\halo3_tag_test.exe"))
                {
                    tools.Add("H3T", Form1.toolsPath + "\\H3EK\\halo3_tag_test.exe");
                    h3tImage.Image = Icon.ExtractAssociatedIcon(Form1.toolsPath + "\\H3EK\\halo3_tag_test.exe").ToBitmap();
                    h3tImage.Visible = true;
                    h3tLabel.Visible = true;
                }
                else
                {
                    tools.Add("H3T", "");
                    h3tImage.Visible = false;
                    h3tLabel.Visible = false;
                }
            }
            else
            {
                tools.Add("H3G", "");
                h3gImage.Visible = false;
                h3gLabel.Visible = false;
                tools.Add("H3S", "");
                h3sImage.Visible = false;
                h3sLabel.Visible = false;
                tools.Add("H3T", "");
                h3tImage.Visible = false;
                h3tLabel.Visible = false;
            }

            // Halo 3: ODST
            if (Directory.Exists(Form1.toolsPath + "\\H3ODSTEK"))
            {
                tools.Add("ODST", Form1.toolsPath + "\\H3ODSTEK");
                if (File.Exists(Form1.toolsPath + "\\H3ODSTEK\\guerilla.exe"))
                {
                    tools.Add("H3OG", Form1.toolsPath + "\\H3ODSTEK\\guerilla.exe");
                    h3ogImage.Image = Icon.ExtractAssociatedIcon(Form1.toolsPath + "\\H3ODSTEK\\guerilla.exe").ToBitmap();
                    h3ogImage.Visible = true;
                    h3ogLabel.Visible = true;
                }
                else
                {
                    tools.Add("H3OG", "");
                    h3ogImage.Visible = false;
                    h3ogLabel.Visible = false;
                }
                if (File.Exists(Form1.toolsPath + "\\H3ODSTEK\\sapien.exe"))
                {
                    tools.Add("H3OS", Form1.toolsPath + "\\H3ODSTEK\\sapien.exe");
                    h3osImage.Image = Icon.ExtractAssociatedIcon(Form1.toolsPath + "\\H3ODSTEK\\sapien.exe").ToBitmap();
                    h3osImage.Visible = true;
                    h3osLabel.Visible = true;
                }
                else
                {
                    tools.Add("H3OS", "");
                    h3osImage.Visible = false;
                    h3osLabel.Visible = false;
                }
                if (File.Exists(Form1.toolsPath + "\\H3ODSTEK\\atlas_tag_test.exe"))
                {
                    tools.Add("H3OT", Form1.toolsPath + "\\H3ODSTEK\\atlas_tag_test.exe");
                    h3otImage.Image = Icon.ExtractAssociatedIcon(Form1.toolsPath + "\\H3ODSTEK\\atlas_tag_test.exe").ToBitmap();
                    h3otImage.Visible = true;
                    h3otLabel.Visible = true;
                }
                else
                {
                    tools.Add("H3OT", "");
                    h3otImage.Visible = false;
                    h3otLabel.Visible = false;
                }
            }
            else
            {
                tools.Add("H3OG", "");
                h3ogImage.Visible = false;
                h3ogLabel.Visible = false;
                tools.Add("H3OS", "");
                h3osImage.Visible = false;
                h3osLabel.Visible = false;
                tools.Add("H3OT", "");
                h3otImage.Visible = false;
                h3otLabel.Visible = false;
            }

            // Halo: Reach
            if (Directory.Exists(Form1.toolsPath + "\\HREK"))
            {
                tools.Add("HR", Form1.toolsPath + "\\HREK");
                if (File.Exists(Form1.toolsPath + "\\HREK\\Foundation.exe"))
                {
                    tools.Add("HRG", Form1.toolsPath + "\\HREK\\Foundation.exe");
                    hrgImage.Image = Icon.ExtractAssociatedIcon(Form1.toolsPath + "\\HREK\\Foundation.exe").ToBitmap();
                    hrgImage.Visible = true;
                    hrgLabel.Visible = true;
                }
                else
                {
                    tools.Add("HRG", "");
                    hrgImage.Visible = false;
                    hrgLabel.Visible = false;
                }
                if (File.Exists(Form1.toolsPath + "\\HREK\\sapien.exe"))
                {
                    tools.Add("HRS", Form1.toolsPath + "\\HREK\\sapien.exe");
                    hrsImage.Image = Icon.ExtractAssociatedIcon(Form1.toolsPath + "\\HREK\\sapien.exe").ToBitmap();
                    hrsImage.Visible = true;
                    hrsLabel.Visible = true;
                }
                else
                {
                    tools.Add("HRS", "");
                    hrsImage.Visible = false;
                    hrsLabel.Visible = false;
                }
                if (File.Exists(Form1.toolsPath + "\\HREK\\reach_tag_test.exe"))
                {
                    tools.Add("HRT", Form1.toolsPath + "\\HREK\\reach_tag_test.exe");
                    hrtImage.Image = Icon.ExtractAssociatedIcon(Form1.toolsPath + "\\HREK\\reach_tag_test.exe").ToBitmap();
                    hrtImage.Visible = true;
                    hrtLabel.Visible = true;
                }
                else
                {
                    tools.Add("HRT", "");
                    hrtImage.Visible = false;
                    hrtLabel.Visible = false;
                }
                if (File.Exists(Form1.toolsPath + "\\HREK\\MegaloEdit.exe"))
                {
                    tools.Add("HRM", Form1.toolsPath + "\\HREK\\MegaloEdit.exe");
                    openMegaloEditHREKToolStripMenuItem.Enabled = true;
                }
                else
                {
                    tools.Add("HRM", "");
                    openMegaloEditHREKToolStripMenuItem.Enabled = false;
                }
            }
            else
            {
                tools.Add("HRG", "");
                hrgImage.Visible = false;
                hrgLabel.Visible = false;
                tools.Add("HRS", "");
                hrsImage.Visible = false;
                hrsLabel.Visible = false;
                tools.Add("HRT", "");
                hrtImage.Visible = false;
                hrtLabel.Visible = false;
                tools.Add("HRM", "");
                openMegaloEditHREKToolStripMenuItem.Enabled = false;
            }

            // Halo 4
            if (Directory.Exists(Form1.toolsPath + "\\H4EK"))
            {
                tools.Add("H4", Form1.toolsPath + "\\H4EK");
                if (File.Exists(Form1.toolsPath + "\\H4EK\\Foundation.exe"))
                {
                    tools.Add("H4G", Form1.toolsPath + "\\H4EK\\Foundation.exe");
                    h4gImage.Image = Icon.ExtractAssociatedIcon(Form1.toolsPath + "\\H4EK\\Foundation.exe").ToBitmap();
                    h4gImage.Visible = true;
                    h4gLabel.Visible = true;
                }
                else
                {
                    tools.Add("H4G", "");
                    h4gImage.Visible = false;
                    h4gLabel.Visible = false;
                }
                if (File.Exists(Form1.toolsPath + "\\H4EK\\sapien.exe"))
                {
                    tools.Add("H4S", Form1.toolsPath + "\\H4EK\\sapien.exe");
                    h4sImage.Image = Icon.ExtractAssociatedIcon(Form1.toolsPath + "\\H4EK\\sapien.exe").ToBitmap();
                    h4sImage.Visible = true;
                    h4sLabel.Visible = true;
                }
                else
                {
                    tools.Add("H4S", "");
                    h4sImage.Visible = false;
                    h4sLabel.Visible = false;
                }
                if (File.Exists(Form1.toolsPath + "\\H4EK\\halo4_tag_test.exe"))
                {
                    tools.Add("H4T", Form1.toolsPath + "\\H4EK\\halo4_tag_test.exe");
                    h4tImage.Image = Icon.ExtractAssociatedIcon(Form1.toolsPath + "\\H4EK\\halo4_tag_test.exe").ToBitmap();
                    h4tImage.Visible = true;
                    h4tLabel.Visible = true;
                }
                else
                {
                    tools.Add("H4T", "");
                    h4tImage.Visible = false;
                    h4tLabel.Visible = false;
                }
                if (File.Exists(Form1.toolsPath + "\\H4EK\\MegaloEdit.exe"))
                {
                    tools.Add("H4M", Form1.toolsPath + "\\H4EK\\MegaloEdit.exe");
                    openMegaloEditH4EKToolStripMenuItem.Enabled = true;
                }
                else
                {
                    tools.Add("H4M", "");
                    openMegaloEditH4EKToolStripMenuItem.Enabled = false;
                }
            }
            else
            {
                tools.Add("H4G", "");
                h4gImage.Visible = false;
                h4gLabel.Visible = false;
                tools.Add("H4S", "");
                h4sImage.Visible = false;
                h4sLabel.Visible = false;
                tools.Add("H4T", "");
                h4tImage.Visible = false;
                h4tLabel.Visible = false;
                tools.Add("H4M", "");
                openMegaloEditH4EKToolStripMenuItem.Enabled = false;
            }

            // Halo 2: Anniversary Multiplayer
            if (Directory.Exists(Form1.toolsPath + "\\H2AMPEK"))
            {
                tools.Add("H2A", Form1.toolsPath + "\\H2AMPEK");
                if (File.Exists(Form1.toolsPath + "\\H2AMPEK\\Foundation.exe"))
                {
                    tools.Add("H2AG", Form1.toolsPath + "\\H2AMPEK\\Foundation.exe");
                    h2agImage.Image = Icon.ExtractAssociatedIcon(Form1.toolsPath + "\\H2AMPEK\\Foundation.exe").ToBitmap();
                    h2agImage.Visible = true;
                    h2agLabel.Visible = true;
                }
                else
                {
                    tools.Add("H2AG", "");
                    h2agImage.Visible = false;
                    h2agLabel.Visible = false;
                }
                if (File.Exists(Form1.toolsPath + "\\H2AMPEK\\sapien.exe"))
                {
                    tools.Add("H2AS", Form1.toolsPath + "\\H2AMPEK\\sapien.exe");
                    h2asImage.Image = Icon.ExtractAssociatedIcon(Form1.toolsPath + "\\H2AMPEK\\sapien.exe").ToBitmap();
                    h2asImage.Visible = true;
                    h2asLabel.Visible = true;
                }
                else
                {
                    tools.Add("H2AS", "");
                    h2asImage.Visible = false;
                    h2asLabel.Visible = false;
                }
                if (File.Exists(Form1.toolsPath + "\\H2AMPEK\\halo2a_tag_test.exe"))
                {
                    tools.Add("H2AT", Form1.toolsPath + "\\H2AMPEK\\halo2a_tag_test.exe");
                    h2atImage.Image = Icon.ExtractAssociatedIcon(Form1.toolsPath + "\\H2AMPEK\\halo2a_tag_test.exe").ToBitmap();
                    h2atImage.Visible = true;
                    h2atLabel.Visible = true;
                }
                else
                {
                    tools.Add("H2AT", "");
                    h2atImage.Visible = false;
                    h2atLabel.Visible = false;
                }
                if (File.Exists(Form1.toolsPath + "\\H2AMPEK\\MegaloEdit.exe"))
                {
                    tools.Add("H2AM", Form1.toolsPath + "\\H2AMPEK\\MegaloEdit.exe");
                    openMegaloEditH2AMEKToolStripMenuItem.Enabled = true;
                }
                else
                {
                    tools.Add("H2AM", "");
                    openMegaloEditH2AMEKToolStripMenuItem.Enabled = false;
                }
            }
            else
            {
                tools.Add("H2AG", "");
                h2agImage.Visible = false;
                h2agLabel.Visible = false;
                tools.Add("H2AS", "");
                h2asImage.Visible = false;
                h2asLabel.Visible = false;
                tools.Add("H2AT", "");
                h2atImage.Visible = false;
                h2atLabel.Visible = false;
                tools.Add("H2AM", "");
                openMegaloEditH2AMEKToolStripMenuItem.Enabled = false;
            }
        }

        // Launches the selected mod tool
        private void LaunchModTool(string key, string baseKey)
        {
            if (tools[key] != "")
            {
                ProcessStartInfo start = new ProcessStartInfo(tools[key]);
                start.WorkingDirectory = tools[baseKey];
                Process.Start(start);
            }
        }

        // Launch Halo: CE Guerilla
        private void hcegImage_DoubleClick(object sender, EventArgs e)
        {
            LaunchModTool("HCEG", "HCE");
        }

        // Launch Halo: CE Sapien
        private void hcesImage_DoubleClick(object sender, EventArgs e)
        {
            LaunchModTool("HCES", "HCE");
        }

        // Launch Halo: CE Tag Test (Standalone)
        private void hcetImage_DoubleClick(object sender, EventArgs e)
        {
            LaunchModTool("HCET", "HCE");
        }

        // Launch Halo 2 Guerilla
        private void h2gImage_DoubleClick(object sender, EventArgs e)
        {
            LaunchModTool("H2G", "H2");
        }

        // Launch Halo 2 Sapien
        private void h2sImage_DoubleClick(object sender, EventArgs e)
        {
            LaunchModTool("H2S", "H2");
        }

        // Launch Halo 2 Tag Test (Standalone)
        private void h2tImage_DoubleClick(object sender, EventArgs e)
        {
            LaunchModTool("H2T", "H2");
        }

        // Launch Halo 3 Guerilla
        private void h3gImage_DoubleClick(object sender, EventArgs e)
        {
            LaunchModTool("H3G", "H3");
        }

        // Launch Halo 3 Sapien
        private void h3sImage_DoubleClick(object sender, EventArgs e)
        {
            LaunchModTool("H3S", "H3");
        }

        // Launch Halo 3 Tag Test (Standalone)
        private void h3tImage_DoubleClick(object sender, EventArgs e)
        {
            LaunchModTool("H3T", "H3");
        }

        // Launch Halo 3: ODST Guerilla
        private void h3ogImage_DoubleClick(object sender, EventArgs e)
        {
            LaunchModTool("H3OG", "ODST");
        }

        // Launch Halo 3: ODST Sapien
        private void h3osImage_DoubleClick(object sender, EventArgs e)
        {
            LaunchModTool("H3OS", "ODST");
        }

        // Launc Halo 3: ODST Tag Test (Standalone)
        private void h3otImage_DoubleClick(object sender, EventArgs e)
        {
            LaunchModTool("H3OT", "ODST");
        }

        // Launch Halo: Reach Foundation
        private void hrgImage_DoubleClick(object sender, EventArgs e)
        {
            LaunchModTool("HRG", "HR");
        }

        // Launch Halo: Reach Sapien
        private void hrsImage_DoubleClick(object sender, EventArgs e)
        {
            LaunchModTool("HRS", "HR");
        }

        // Launch Halo: Reach Tag Test (Standalone)
        private void hrtImage_DoubleClick(object sender, EventArgs e)
        {
            LaunchModTool("HRT", "HR");
        }

        // Launch Halo 4 Foundation
        private void h4gImage_DoubleClick(object sender, EventArgs e)
        {
            LaunchModTool("H4G", "H4");
        }

        // Launch Halo 4 Sapien
        private void h4sImage_DoubleClick(object sender, EventArgs e)
        {
            LaunchModTool("H4S", "H4");
        }

        // Launch Halo 4 Tag Test (Standalone)
        private void h4tImage_DoubleClick(object sender, EventArgs e)
        {
            LaunchModTool("H4T", "H4");
        }

        // Launch Halo 2: Anniversary Foundation
        private void h2agImage_DoubleClick(object sender, EventArgs e)
        {
            LaunchModTool("H2AG", "H2A");
        }

        // Launch Halo 2: Anniversary Sapien
        private void h2asImage_DoubleClick(object sender, EventArgs e)
        {
            LaunchModTool("H2AS", "H2A");
        }

        // Launch Halo 2: Anniversary Tag Test (Standalone)
        private void h2atImage_DoubleClick(object sender, EventArgs e)
        {
            LaunchModTool("H2AT", "H2A");
        }

        // Launch Halo: Reach MegaloEdit
        private void openMegaloEditHREKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchModTool("HRM", "HR");
        }

        // Launch Halo 4 MegaloEdit
        private void openMegaloEditH4EKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchModTool("H4M", "H4");
        }

        // Launch Halo 2: Anniversary MegaloEdit
        private void openMegaloEditH2AMEKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchModTool("H2AM", "H2A");
        }

        // Run Tool
        private void runToolToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RunToolForm tool = new RunToolForm();
            tool.Show();
        }

        // Edit Directories
        private void editDirectoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectoryForm dir = new DirectoryForm();
            dir.Show();
        }
    }
}
