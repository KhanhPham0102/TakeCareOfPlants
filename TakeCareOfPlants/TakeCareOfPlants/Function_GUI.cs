﻿using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TakeCareOfPlants
{
    public static class Function_GUI
    {
        [DllImport("user32")]
        private static extern bool AnimateWindow(IntPtr hwnd, int time, AnimateWindowFlags flags);

        [Flags]
        public enum AnimateWindowFlags
        {
            AW_HOR_POSITIVE = 0x00000001,
            AW_HOR_NEGATIVE = 0x00000002,
            AW_VER_POSITIVE = 0x00000004,
            AW_VER_NEGATIVE = 0x00000008,
            AW_CENTER = 0x00000010,
            AW_HIDE = 0x00010000,
            AW_ACTIVATE = 0x00020000,
            AW_SLIDE = 0x00040000,
            AW_BLEND = 0x00080000
        }

        public enum ShadowBorder
        {
            WM_NCHITTEST = 0x84,
            HTCLIENT = 0x1,
            HTCAPTION = 0x2,
            CS_DROPSHADOW = 0x00020000,
            WM_NCPAINT = 0x0085,
            WM_ACTIVATEAPP = 0x001C,
            WM_NCLBUTTONDBLCLK = 0x00A3
        }

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        public static void HideShowPage(Form form1, Form form2)
        {
            AnimateWindow(form1.Handle, 1000, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
            AnimateWindow(form2.Handle, 300, AnimateWindowFlags.AW_BLEND);
            form2.Show();
        }

        public static void HidePage(Form form)
        {
            AnimateWindow(form.Handle, 1000, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
        }

        public static void ShowPage(Form form)
        {
            AnimateWindow(form.Handle, 300, AnimateWindowFlags.AW_BLEND);
            form.Show();
        }

        public static void CloseApp()
        {
            switch (MessageBox.Show("Do you want to close this app?", "Close App", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) {
                case DialogResult.Yes: {
                        Application.Exit();
                        break;
                    }
                case DialogResult.No: {
                        new CancelEventArgs().Cancel = true;
                        break;
                    }
            }
        }

        public static bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6) {
                int enabled = 0;
                Function_GUI.DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
    }
}