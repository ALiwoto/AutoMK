using AutoMK.WinCore;
using AutoMK.WinCore.Keyboard;
using AutoMK.WinCore.Mouse;

namespace AutoMK.WinUI
{
    public partial class MainForm : PageBase
    {
        public MainForm()
        {
            InitializeComponent();

            Keyboard ??= new KeyboardProvider();
            Mouse ??= new MouseProvider();
        }
    }
}