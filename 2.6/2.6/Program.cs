using System;

namespace _2._6
{
    class Program
    {
        static void Main(string[] args)
        {
           var converter = new Converter(usd: 1d / 26.73d, eur: 1d / 31.32d, krn: 1d / 1.23d);
            Console.WriteLine("Варианты конвертации:");
            Console.WriteLine("1. USD -> UAH");
            Console.WriteLine("2. EUR -> UAH");
            Console.WriteLine("3. KRN -> UAH");
            Console.WriteLine("4. UAH -> USD");
            Console.WriteLine("5. UAH -> EUR");
            Console.WriteLine("6. UAH -> KRN");
            Console.Write("Ваш выбор: ");
            int choice;
            bool choiceParsed = int.TryParse(Console.ReadLine(), out choice);

            Console.Write("Кол-во единиц валюты: ");
            double value;
            bool valueParsed = double.TryParse(Console.ReadLine(), out value);


            Console.Write("Результат: ");

            switch (choice)
            {
                case 1:
                    Console.WriteLine(converter.ConvertFromUsd(value));
                    break;


                case 2:
                    Console.WriteLine(converter.ConvertFromEur(value));
                    break;


                case 3:
                    Console.WriteLine(converter.ConvertFromKrn(value));
                    break;


                case 4:
                    Console.WriteLine(converter.ConvertToUsd(value));
                    break;


                case 5:
                    Console.WriteLine(converter.ConvertToEur(value));
                    break;


                case 6:
                    Console.WriteLine(converter.ConvertToKrn(value));
                    break;
            }

            Console.ReadLine();
        }
    }
}
