using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaloWorkshopManager
{
    public partial class DirectoryForm : Form
    {
        public DirectoryForm()
        {
            InitializeComponent();
            steamDirBox.Text = Form1.steamDir;
            modToolsDir.Text = Form1.toolsPath;
        }

        private void steamDirBrowseButton_Click(object sender, EventArgs e)
        {
            if (steamExeDialog.ShowDialog() == DialogResult.OK)
            {
                steamDirBox.Text = steamExeDialog.FileName;
            }
        }

        private void modToolsBrowseButton_Click(object sender, EventArgs e)
        {
            if (modToolsDialog.ShowDialog() == DialogResult.OK)
            {
                modToolsDir.Text = modToolsDialog.SelectedPath;
            }
        }

        // Saves Paths to memory and to file
        private void savePathsButton_Click(object sender, EventArgs e)
        {
            Form1.steamDir = steamDirBox.Text;
            Form1.toolsPath = modToolsDir.Text;
            Form1.SaveConfigFile();
            Close();
        }
    }
}
