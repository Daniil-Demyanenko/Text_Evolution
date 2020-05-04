using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Evolution
{
    class Color
    {
        public ConsoleColor BackLog;
        public ConsoleColor BackText;
        public ConsoleColor ColorLog;
        public ConsoleColor ColorText;

        public Color()
        {
            BackText = ConsoleColor.Black;
            BackLog = ConsoleColor.Black;
            ColorLog = ConsoleColor.Cyan;
            ColorText = ConsoleColor.Yellow;
        }

        public void LogOut(string text)
        {
            var Back = Console.BackgroundColor;
            var Color = Console.ForegroundColor;
            Console.BackgroundColor = BackLog;
            Console.ForegroundColor = ColorLog;
            Console.Write(text);
            Console.BackgroundColor = Back;
            Console.ForegroundColor = Color;
        }
        public void LogOutLine(string text)
        {
            LogOut(text + "\n");
        }
    }
}
