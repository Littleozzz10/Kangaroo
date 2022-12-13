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
    public partial class RunToolForm : Form
    {
        public RunToolForm()
        {
            InitializeComponent();
            copyLabel.Visible = false;
        }

        // Running tool
        private void runButton_Click(object sender, EventArgs e)
        {
            string run = "";
            if (toolTypeBox.Text == "Tool")
            {
                run = run + "tool.exe";
            }
            else if (toolTypeBox.Text == "Tool Fast")
            {
                run = run + "tool_fast.exe";
            }
            try
            {
                ProcessStartInfo start = new ProcessStartInfo("cmd.exe");
                start.WorkingDirectory = Form1.toolsPath + "\\" + gameBox.Text;
                Process.Start(start);
                new Microsoft.VisualBasic.Devices.Computer().Clipboard.SetText(run + " " + paramBox.Text);
                copyLabel.Visible = true;
            }
            catch
            {
                // TODO: Add console output
            }
        }
    }
}
