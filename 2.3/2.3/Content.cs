using System;
using System.Collections.Generic;
using System.Text;

namespace _2._3
{
    class Content
    {
        public string content;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write($"Контент книги: {content}. ");

            Console.ResetColor();
        }
    }
}
