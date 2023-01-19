using System.Windows.Forms;

namespace AutoMK.WinUI
{
    partial class MainForm
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "AutoMK";
            this.Name = "AutoMK-MainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.SuspendLayout();

            //---------------------------------------------
            this.FirstToolStrip = new ToolStrip();
            this.SecondToolStrip = new ToolStrip();
            this.LeftToolStrip = new ToolStrip();

            this.FileDropDownButton = new ToolStripDropDownButton();
            this.FileNewToolStripButton = new ToolStripButton();
            this.FileOpenToolStripButton = new ToolStripButton();

            this.EditDropDownButton = new ToolStripDropDownButton();

            this.InsertDropDownButton = new ToolStripDropDownButton();

            this.ToolsDropDownButton = new ToolStripDropDownButton();

            this.HelpDropDownButton = new ToolStripDropDownButton();
            //---------------------------------------------
            this.FirstToolStrip.Dock = DockStyle.Top;
            this.SecondToolStrip.Dock = DockStyle.Top;
            this.LeftToolStrip.Dock = DockStyle.Left;
            //---------------------------------------------
            this.FirstToolStrip.Name = "FirstToolStrip";
            this.SecondToolStrip.Name = "SecondToolStrip";
            this.LeftToolStrip.Name = "LeftToolStrip";

            this.FileDropDownButton.Name = "FileDropDownButton";

            this.EditDropDownButton.Name = "EditDropDownButton";

            this.InsertDropDownButton.Name = "InsertDropDownButton";

            this.ToolsDropDownButton.Name = "ToolsDropDownButton";
            //---------------------------------------------
            this.FileDropDownButton.Text = "File";
            //---------------------------------------------
            //---------------------------------------------
            this.FirstToolStrip.Items.AddRange(new[]
            {
                this.FileDropDownButton,
            });

            //---------------------------------------------
            //---------------------------------------------


            //---------------------------------------------
            this.Controls.AddRange(new[]
            {
                this.LeftToolStrip,
                this.SecondToolStrip,
                this.FirstToolStrip,
            });

            //---------------------------------------------
            this.FirstToolStrip.ResumeLayout(false);
            this.FirstToolStrip.PerformLayout();
            this.SecondToolStrip.ResumeLayout(false);
            this.SecondToolStrip.PerformLayout();
            this.LeftToolStrip.ResumeLayout(false);
            this.LeftToolStrip.PerformLayout();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}