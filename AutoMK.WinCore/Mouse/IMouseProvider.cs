using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMK.WinCore.Mouse
{
    public interface IMouseProvider
    {
        void MoveToPoint(int x, int y);
        void LeftClick();
        void LeftClick(int count);
        void LeftDown();
        void LeftUp();
        void RightClick();
        void RightDown();
        void RightUp();
        void WheelDown();
        void WheelUp();
        void WheelDown(int amount);
        void WheelUp(int amount);
    }
}
