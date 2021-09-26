using System;
using System.Collections.Generic;
using System.Text;

namespace _2._3
{
    class Author
    {
        public string name;

        public void Show()

        {

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write($"Автор книги: {name}. ");

            Console.ResetColor();
        }
    }
}
