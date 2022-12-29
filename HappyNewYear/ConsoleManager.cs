using System.Runtime.InteropServices;

namespace HappyNewYear
{
    internal static class ConsoleManager
    {
        private const int SW_HIDE = 0;  //окно спрятано
        private const int SW_SHOW = 5;  //окно видно

        //kernel32
        [DllImport("kernel32.dll")] //библиотека для метода GetConsoleWindow
        private static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]//библиотека для метода ShowWindow
        private static extern IntPtr ShowWindow(IntPtr hwnd, int nVmdShow);
        static public void Show()
        {
            var win = GetConsoleWindow();//узнаем текущее окно
            ShowWindow(win, SW_SHOW);    //показываем его
        }
        static public void Hide()
        {
            var win = GetConsoleWindow();   //узнаем текущее окно
            ShowWindow(win, SW_HIDE);       //скрываем его
        }
    }
}
