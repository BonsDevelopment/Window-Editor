using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Editor.Handle
{
    public static class Configuration
    {
        private static RECT controlRect;

        public static int GetControlSizeW(IntPtr Handle)
        {

            if (NativeMethods.GetWindowRect(Handle, out controlRect))
            {
                return controlRect.Right - controlRect.Left;
            }

            return 0;

        }

        public static int GetControlSizeH(IntPtr Handle)
        {

            if (NativeMethods.GetWindowRect(Handle, out controlRect))
            {
                return controlRect.Bottom - controlRect.Top;
            }

            return 0;

        }

        public static Point WindowLocation(IntPtr Handle)
        {

            if (NativeMethods.GetWindowRect(Handle, out controlRect))
            {
                return new Point(controlRect.Left, controlRect.Top);
            }

            return new Point(0, 0);

        }
    }
}
