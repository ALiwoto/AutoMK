using AutoMK.WinCore.Keyboard;
using AutoMK.WinCore.Mouse;
using System.ComponentModel;
using System.Windows.Forms;

namespace AutoMK.WinCore
{
    [DefaultEvent("Load")]
    [Designer("")]
    [DesignerCategory("")]
    [DesignTimeVisible(false)]
    [InitializationEvent("")]
    [ToolboxItem(false)]
    [ToolboxItemFilter("")]
    public abstract class PageBase : Form
    {
        public virtual IKeyboardProvider? Keyboard { get; set; }
        public virtual IMouseProvider? Mouse { get; set; }
        public PageBase()
        {
            Keyboard ??= new KeyboardProvider();
            Mouse ??= new MouseProvider();
        }
    }
}