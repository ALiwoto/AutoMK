using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMK.WinCore.Keyboard
{
    public interface IKeyboardProvider
    {
        void Press(string keys);
    }
}
