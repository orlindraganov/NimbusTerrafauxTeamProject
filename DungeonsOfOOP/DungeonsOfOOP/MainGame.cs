using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DungeonsOfOOP.Structures;
using DungeonsOfOOP.Views;

namespace DungeonsOfOOP
{
    class MainGame
    {
        public static Renderer Renderer = new Renderer();

        static void Main(string[] args)
        {
            Renderer.SetConsoleProperties();
            Renderer.SetPictureAtPosition("doncho", new Position(10, 40));
            Renderer.SetPictureAtPosition("cuki", new Position(150, 40));
            Renderer.SetPictureAtPosition("marto", new Position(10, 200));
            Renderer.SetPictureAtPosition("koceto", new Position(150, 200));
        }
    }
}
