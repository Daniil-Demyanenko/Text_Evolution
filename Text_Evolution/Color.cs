using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Evolution
{
    static class Color
    {
        /// <summary>
        /// Фон для LogOut.
        /// </summary>
        static public ConsoleColor BackLog = ConsoleColor.Black;
        /// <summary>
        /// Фон для TextOut
        /// </summary>
        static public ConsoleColor BackText = ConsoleColor.Black;
        /// <summary>
        /// Цвет текста для LogOut
        /// </summary>
        static public ConsoleColor ColorLog = ConsoleColor.Cyan;
        /// <summary>
        /// Цвет текста для TextOut
        /// </summary>
        static public ConsoleColor ColorText = ConsoleColor.Yellow;


        /// <summary>
        /// Цветной вывод.
        /// </summary>
        /// <param name="text">Текст.</param>
        static public void LogOut(string text)
        {
            var Back = Console.BackgroundColor;
            var Color = Console.ForegroundColor;
            Console.BackgroundColor = BackLog;
            Console.ForegroundColor = ColorLog;
            Console.Write(text);
            Console.BackgroundColor = Back;
            Console.ForegroundColor = Color;
        }
        /// <summary>
        /// Цветной вывод с новой строки.
        /// </summary>
        /// <param name="text">Текст.</param>
        static public void LogOutLine(string text)
        {
            LogOut(text + "\n");
        }

        /// <summary>
        /// Цветной вывод.
        /// </summary>
        /// <param name="text">Текст.</param>
        static public void TextOut(string text)
        {
            var Back = Console.BackgroundColor;
            var Color = Console.ForegroundColor;
            Console.BackgroundColor = BackText;
            Console.ForegroundColor = ColorText;
            Console.Write(text);
            Console.BackgroundColor = Back;
            Console.ForegroundColor = Color;
        }
        /// <summary>
        /// Цветной вывод.
        /// </summary>
        /// <param name="text">Текст.</param>
        static public void TexOutLine(string text)
        {
            LogOut(text + "\n");
        }
    }
}
