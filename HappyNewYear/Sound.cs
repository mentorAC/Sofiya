using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HappyNewYear
{
    static class Sound
    {
        private const int WM_APPCOMMAND = 0x319;

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;

        [DllImport("kernel32.dll")] //библиотека для метода GetConsoleWindow
        private static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        public static void Louder()
        {
            var win = GetConsoleWindow();
            SendMessage(win, WM_APPCOMMAND, IntPtr.Zero, (IntPtr)APPCOMMAND_VOLUME_UP);
        }
        public static void Quiet()
        {
            var win = GetConsoleWindow();
            SendMessage(win, WM_APPCOMMAND, IntPtr.Zero, (IntPtr)APPCOMMAND_VOLUME_DOWN);

        }
        public static void Mute()
        {
            var win = GetConsoleWindow();
            SendMessage(win, WM_APPCOMMAND, IntPtr.Zero, (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }
        public static void VulumeMax()
        {
            for (int i = 0; i < 100; i++)
            {
                Louder();
            }
        }
    }
}
