using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Gdi3
{
    public class Class1
    {
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateSolidBrush(uint color);

        [DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);

        [DllImport("user32.dll")]
        public static extern int GetSystemMetrics(int nIndex);

        [DllImport("gdi32.dll")]
        public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

        [DllImport("gdi32.dll")]
        public static extern bool Rectangle(IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

        [DllImport("kernel32.dll")]
        public static extern void Sleep(int dwMilliseconds);

        [DllImport("user32.dll")]
        public static extern IntPtr GetDesktopWindow();

        const int SM_CXSCREEN = 0;
        const int SM_CYSCREEN = 1;

        static void Main(string[] args)
        {
            while (true)
            {
                IntPtr desk = GetDC(IntPtr.Zero);
                int screenWidth = GetSystemMetrics(SM_CXSCREEN);
                int screenHeight = GetSystemMetrics(SM_CYSCREEN);

                Random rand = new Random();

                for (int i = 0; i < 100; i++)
                {
                    int x = rand.Next(screenWidth);
                    int y = rand.Next(screenHeight);
                    int width = rand.Next(screenWidth - x);
                    int height = rand.Next(screenHeight - y);

                    IntPtr brush = CreateSolidBrush((uint)((rand.Next(255) << 16) | (rand.Next(255) << 8) | rand.Next(255)));
                    SelectObject(desk, brush);
                    Rectangle(desk, x, y, x + width, y + height);
                    DeleteObject(brush);
                    Sleep(10);
                }

                ReleaseDC(GetDesktopWindow(), desk);
            }
        }
    }

}

