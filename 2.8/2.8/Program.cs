using System;

namespace _2._8
{
    class Program
    {
        static void Main(string[] args)
        {          
                Invoice invoice = new Invoice(account: 185, customer: "John Baton", provider: "Kievstar", article: "2", quantity: 8);
                Console.WriteLine($"Сумма с НДС: {invoice.CalculateWithTax()}");
                Console.WriteLine($"Сумма без НДС: {invoice.CalculateWithoutTax()}");
                Console.ReadKey();
        }
    }
}
