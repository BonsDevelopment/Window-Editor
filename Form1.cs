using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Window_Editor.Handle;
namespace Window_Editor
{
    public partial class Form1 : Form
    {

        //fairly sloppy code due to me being picky on how I wanted it to work. 
        
        int offsetX = 0, offsetY = 0;

        public bool properClick = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void controlGrabber1_MouseDown(object sender, MouseEventArgs e)
        {
            controlTimer.Enabled = true;
            controlTimer.Start();
        }

        private void controlGrabber1_MouseUp(object sender, MouseEventArgs e)
        {
            
            controlTimer.Stop();
            controlTimer.Enabled = false;

            xLblEdit.Text = CommonFields.X.ToString();
            yLblEdit.Text = CommonFields.Y.ToString();
            hLblEdit.Text = CommonFields.Height.ToString();
            wLblEdit.Text = CommonFields.Width.ToString();

            defaultLblEdit.Text = $"({CommonFields.X},{CommonFields.Y})";
            defaultLblEdit2.Text = $"({CommonFields.Width},{CommonFields.Height})";
        }


        private void controlTimer_Tick(object sender, EventArgs e)
        {

            IntPtr hWnd = NativeMethods.WindowFromPoint(Cursor.Position);

            CommonFields.Handle = hWnd;
            UpdateLabel();

        }


        private void UpdateLabel()
        {
            CommonFields.Height = Configuration.GetControlSizeH(CommonFields.Handle);
            CommonFields.Width = Configuration.GetControlSizeW(CommonFields.Handle);

            uint lpdwProcessid;

            NativeMethods.GetWindowThreadProcessId(CommonFields.Handle, out lpdwProcessid);

            CommonFields.ParentHandle = Process.GetProcessById((int)lpdwProcessid).MainWindowHandle;


            Point mainLoc = Configuration.WindowLocation(NativeMethods.GetParent(CommonFields.Handle));
            Point contLoc = Configuration.WindowLocation(CommonFields.Handle);

            if (NativeMethods.GetParent(CommonFields.Handle) == CommonFields.ParentHandle)
            {
                CommonFields.Y = ((contLoc.Y - mainLoc.Y) - CommonFields.TitleOffset);
                CommonFields.X = ((contLoc.X - mainLoc.X) - CommonFields.WindowOffset);
            }
            else
            {
                CommonFields.Y = ((contLoc.Y - mainLoc.Y));
                CommonFields.X = ((contLoc.X - mainLoc.X));
            }

            xLblEdit.Text = CommonFields.X.ToString();
            yLblEdit.Text = CommonFields.Y.ToString();
            hLblEdit.Text = CommonFields.Height.ToString();
            wLblEdit.Text = CommonFields.Width.ToString();

        }

        private void editCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (editCheckBox.Checked)
            {
                editTimer.Enabled = true;
                editTimer.Start();
            }
            else
            {
                editTimer.Stop();
                editTimer.Enabled = false;               
            }
        }

        private void editTimer_Tick(object sender, EventArgs e)
        {
            IntPtr hWnd = NativeMethods.WindowFromPoint(Cursor.Position);

            if (hWnd == CommonFields.Handle) properClick = true;


            Point mainLoc = Configuration.WindowLocation(NativeMethods.GetParent(CommonFields.Handle));

            Point contLoc = Configuration.WindowLocation(CommonFields.Handle);

            if (NativeMethods.GetAsyncKeyState(Keys.CapsLock))
            {
                editTimer.Stop();
                editTimer.Enabled = false;
                editCheckBox.Checked = false;
            }

            if (properClick == false)
                return;

            if (NativeMethods.GetAsyncKeyState(Keys.Right))
            {
                int updateWidth = CommonFields.Width++;
                NativeMethods.MoveWindow(CommonFields.Handle, CommonFields.X, CommonFields.Y, updateWidth, CommonFields.Height, true);
            }

            if (NativeMethods.GetAsyncKeyState(Keys.Left))
            {
                int updateWidth = CommonFields.Width--;
                NativeMethods.MoveWindow(CommonFields.Handle, CommonFields.X, CommonFields.Y, updateWidth, CommonFields.Height, true);
                return;
            }

            if (NativeMethods.GetAsyncKeyState(Keys.Up))
            {
                int updateHeight = CommonFields.Height++;
                NativeMethods.MoveWindow(CommonFields.Handle, CommonFields.X, CommonFields.Y, CommonFields.Width, updateHeight, true);
            }

            if (NativeMethods.GetAsyncKeyState(Keys.Down))
            {
                int updateHeight = CommonFields.Height--;
                NativeMethods.MoveWindow(CommonFields.Handle, CommonFields.X, CommonFields.Y, CommonFields.Width, updateHeight, true);
            }
            hLblEdit.Text = CommonFields.Height.ToString();
            wLblEdit.Text = CommonFields.Width.ToString();
            if (NativeMethods.GetAsyncKeyState(Keys.RButton) && NativeMethods.GetAsyncKeyState(Keys.LControlKey))
            {
               
                if (offsetY == 0)
                    offsetY = Cursor.Position.Y - contLoc.Y;
                if (offsetX == 0)
                    offsetX = Cursor.Position.X - contLoc.X;

                if (NativeMethods.GetParent(CommonFields.Handle) == CommonFields.ParentHandle)
                {
                    NativeMethods.MoveWindow(CommonFields.Handle, ((Cursor.Position.X - mainLoc.X) - CommonFields.WindowOffset) - offsetX, ((Cursor.Position.Y - mainLoc.Y) - CommonFields.TitleOffset) - offsetY, CommonFields.Width, CommonFields.Height, true);
                }
                else
                {
                    NativeMethods.MoveWindow(CommonFields.Handle, ((Cursor.Position.X - mainLoc.X)) - offsetX, ((Cursor.Position.Y - mainLoc.Y)) - offsetY, CommonFields.Width, CommonFields.Height, true);
                }
                UpdateLabel();
                return;
            }

            properClick = false;
            offsetX = 0;
            offsetY = 0;
        }
    }
}
