namespace HaloWorkshopManager
{
    partial class RunToolForm
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
            this.toolTypeBox = new System.Windows.Forms.ComboBox();
            this.gameBox = new System.Windows.Forms.ComboBox();
            this.runButton = new System.Windows.Forms.Button();
            this.paramBox = new System.Windows.Forms.TextBox();
            this.copyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toolTypeBox
            // 
            this.toolTypeBox.FormattingEnabled = true;
            this.toolTypeBox.Items.AddRange(new object[] {
            "Tool",
            "Tool Fast"});
            this.toolTypeBox.Location = new System.Drawing.Point(12, 12);
            this.toolTypeBox.Name = "toolTypeBox";
            this.toolTypeBox.Size = new System.Drawing.Size(96, 23);
            this.toolTypeBox.TabIndex = 0;
            this.toolTypeBox.Text = "Tool";
            // 
            // gameBox
            // 
            this.gameBox.FormattingEnabled = true;
            this.gameBox.Items.AddRange(new object[] {
            "HCEEK",
            "H2EK",
            "H3EK",
            "H3ODSTEK",
            "HREK",
            "H4EK",
            "H2AMPEK"});
            this.gameBox.Location = new System.Drawing.Point(114, 12);
            this.gameBox.Name = "gameBox";
            this.gameBox.Size = new System.Drawing.Size(94, 23);
            this.gameBox.TabIndex = 1;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(214, 11);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // paramBox
            // 
            this.paramBox.Location = new System.Drawing.Point(12, 41);
            this.paramBox.Name = "paramBox";
            this.paramBox.Size = new System.Drawing.Size(277, 23);
            this.paramBox.TabIndex = 3;
            // 
            // copyLabel
            // 
            this.copyLabel.AutoSize = true;
            this.copyLabel.Location = new System.Drawing.Point(5, 73);
            this.copyLabel.Name = "copyLabel";
            this.copyLabel.Size = new System.Drawing.Size(287, 15);
            this.copyLabel.TabIndex = 4;
            this.copyLabel.Text = "The tool command has been copied to the clipboard.";
            // 
            // RunToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 97);
            this.Controls.Add(this.copyLabel);
            this.Controls.Add(this.paramBox);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.gameBox);
            this.Controls.Add(this.toolTypeBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(318, 136);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(318, 136);
            this.Name = "RunToolForm";
            this.ShowIcon = false;
            this.Text = "Run Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox toolTypeBox;
        private ComboBox gameBox;
        private Button runButton;
        private TextBox paramBox;
        private Label copyLabel;
    }
}