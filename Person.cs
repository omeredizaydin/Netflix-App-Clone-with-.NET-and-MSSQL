using System;
using System.Collections.Generic;
using System.Text;

namespace netflixApp
{
    class Person
    {
        public string email { get; set; }
        public int phone { get; set; } //pw

        public Person(string email, int phone)
        {
            this.email = email;
            this.phone = phone;
        }
    }
}
