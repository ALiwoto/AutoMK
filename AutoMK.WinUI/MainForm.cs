using AutoMK.WinCore;
using AutoMK.WinCore.Keyboard;
using AutoMK.WinCore.Mouse;
using System.Windows.Forms;

namespace AutoMK.WinUI
{
    public partial class MainForm : PageBase
    {

        public virtual ToolStrip FirstToolStrip { get; set; }
        public virtual ToolStrip SecondToolStrip { get; set; }
        public virtual ToolStrip LeftToolStrip { get; set; }
        public virtual ToolStripDropDownButton FileDropDownButton { get; set; }
        public virtual ToolStripButton FileNewToolStripButton { get; set; }
        public virtual ToolStripButton FileOpenToolStripButton { get; set; }
        public virtual ToolStripDropDownButton EditDropDownButton { get; set; }
        public virtual ToolStripDropDownButton InsertDropDownButton { get; set; }
        public virtual ToolStripDropDownButton ToolsDropDownButton { get; set; }
        public virtual ToolStripDropDownButton HelpDropDownButton { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }
    }
}