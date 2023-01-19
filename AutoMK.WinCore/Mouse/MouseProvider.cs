using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMK.WinCore.Mouse
{
    public class MouseProvider : IMouseProvider
    {
        public virtual void MoveToPoint(int x, int y) =>
            MouseControl.MoveToPoint(x, y);
        public virtual void LeftClick() =>
            MouseControl.LeftClick();
        public virtual void LeftClick(int count)
        {
            for (int i = 0; i < count; i++)
            {
                LeftClick();
            }
        }
        public virtual void LeftDown() =>
            MouseControl.LeftDown();
        public virtual void LeftUp() =>
            MouseControl.LeftUp();
        public virtual void RightClick() =>
            MouseControl.RightClick();
        public virtual void RightDown() =>
            MouseControl.RightDown();
        public virtual void RightUp() =>
            MouseControl.RightUp();
        public virtual void WheelDown() =>
            MouseControl.WheelDown();
        public virtual void WheelUp() =>
            MouseControl.WheelUp();
        public virtual void WheelDown(int amount) =>
            MouseControl.WheelDown(amount);
        public virtual void WheelUp(int amount) =>
            MouseControl.WheelUp(amount);
    }
}
