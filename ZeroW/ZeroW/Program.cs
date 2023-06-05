using System.Runtime.InteropServices;
namespace ZeroW
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Win32.SetCursorPos(500, 500);
                Thread.Sleep(1000);
                Win32.SetCursorPos(505, 500);
                Thread.Sleep(15000);
            }
        }
    }
    public class Win32
    {
        [DllImport("User32.Dll")]
        public static extern long SetCursorPos(int x, int y);

        [DllImport("User32.Dll")]
        public static extern bool ClientToScreen(IntPtr hWnd, ref POINT point);

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int x;
            public int y;

            public POINT(int X, int Y)
            {
                x = X;
                y = Y;
            }
        }
    }

}