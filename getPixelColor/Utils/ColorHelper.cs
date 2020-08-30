using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace getPixelColor.Utils
{
    public static class ColorHelper
    {
        /// <summary>
        /// 获取指定窗口的设备场景
        /// </summary>
        /// <param name="hwnd">将获取其设备场景的窗口的句柄。若为0，则要获取整个屏幕的DC</param>
        /// <returns>指定窗口的设备场景句柄，出错则为0</returns>
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);

        /// <summary>
        /// 释放由调用GetDC函数获取的指定设备场景
        /// </summary>
        /// <param name="hwnd">要释放的设备场景相关的窗口句柄</param>
        /// <param name="hdc">要释放的设备场景句柄</param>
        /// <returns>执行成功为1，否则为0</returns>
        [DllImport("user32.dll")]
        public static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

        /// <summary>
        /// 在指定的设备场景中取得一个像素的RGB值
        /// </summary>
        /// <param name="hdc">一个设备场景的句柄</param>
        /// <param name="p">逻辑坐标中要检查的坐标</param>
        /// <returns>指定点的颜色</returns>
        [DllImport("gdi32.dll")]
        private static extern int GetPixel(IntPtr hdc, Point p);

        public static bool PixelColor(Point point, out Color color)
        {
            IntPtr hdc = GetDC(new IntPtr(0));//取到设备场景(0就是全屏的设备场景) 
            int c = GetPixel(hdc, point);//取指定点颜色 
            ReleaseDC(IntPtr.Zero, hdc);
            color = Color.FromArgb(
                c & 0xFF,                   //转换R 
                (c & 0xFF00) / 256,       //转换G 
                (c & 0xFF0000) / 65536);   //转换B 
            return true;
        }


    }
}
