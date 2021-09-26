using System;
using System.Collections.Generic;
using System.Text;

namespace _2._5
{
    class User
    {
        public readonly string creationDate;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public User()
        {
            creationDate = DateTime.Now.ToString();

        }
    }
}
