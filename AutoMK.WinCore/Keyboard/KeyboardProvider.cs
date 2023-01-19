using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMK.WinCore.Keyboard
{
    public class KeyboardProvider : IKeyboardProvider
    {
        public KeyboardProvider()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="keys"></param>
        /// <example>
        /// # Examples
        /// SendWait("{F5}{ENTER}")
        /// [System.Windows.Forms.SendKeys]::SendWait("~Name:{TAB}")
        /// [System.Windows.Forms.SendKeys]::SendWait("ABCDEFGHIJKLM~")
        /// [System.Windows.Forms.SendKeys]::SendWait("ABCDEFGHIJKLM{BACKSPACE}~")
        /// [System.Windows.Forms.SendKeys]::SendWait("^{HOME}{RIGHT}{RIGHT}{RIGHT}{RIGHT}{RIGHT}~{DELETE}")
        /// [System.Windows.Forms.SendKeys]::SendWait("%F")
        /// [System.Windows.Forms.SendKeys]::SendWait("X")
        /// [System.Windows.Forms.SendKeys]::SendWait("N")
        /// </example>
        public void Press(string keys) =>
            SendKeys.SendWait(keys);
    }
}
