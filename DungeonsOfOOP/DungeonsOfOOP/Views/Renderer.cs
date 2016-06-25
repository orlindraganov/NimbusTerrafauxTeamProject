using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace DungeonsOfOOP.Views
{
    using Structures;
    using Interfaces;

    public class Renderer : IDrawable
    {
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleWindow", SetLastError = true)]
        private static extern IntPtr GetConsoleHandle();

        public void DrawAtPosition(Position position, object obj)
        {
            throw new NotImplementedException();
        }

        public void SetPictureAtPosition(string name, Position pos)
        {
            var handler = GetConsoleHandle();

            using (var graphics = Graphics.FromHwnd(handler))
            using (var image = Image.FromFile(@"..\..\Resources\Images\" + name + ".png"))
                graphics.DrawImage(image, pos.X, pos.Y, 130, 150);
        }

        public void SetConsoleProperties()
        {
            Console.Title = "Dungeons of OOP";
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
            Console.CursorVisible = false;
        }
    }
}
