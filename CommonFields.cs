using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Editor
{
    public static class CommonFields
    {

        public static int X { get; set; }
        public static int Y { get; set; }

        public static int Height { get; set; }
        public static int Width { get; set; }

        public static IntPtr Handle { get; set; }
        public static IntPtr ParentHandle { get; set; }

        public static int TitleOffset = 30;
        public static int WindowOffset = 8;
    }
}
