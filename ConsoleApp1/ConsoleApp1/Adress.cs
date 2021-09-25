using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Adress
    {
        public string country, city, street;
        public int index, house, apartment;

        public Adress()
        {
            Index = index;

            Country = country;

            City = city;

            Street = street;

            House = house;

            Apartment = apartment;
        }
        private static int Index { get; set; }
        private static string Country { get; set; }
        private static string City { get; set; }
        private static string Street { get; set; }
        private static int House { get; set; }
        private static int Apartment { get; set; }
    }
}
