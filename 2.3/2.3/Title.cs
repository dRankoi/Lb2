using System;
using System.Collections.Generic;
using System.Text;

namespace _2._3
{
    class Title
    {
        public string name;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write($"Название книги: {name}. ");

            Console.ResetColor();
        }
    }
}
