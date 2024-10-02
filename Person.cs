using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Revise
{
    internal class Person
    {
        private int age { get; set; }
        private string gender { get; set; }

        public Person(int a_age, string a_gender)
        {
            if (a_gender.ToUpper() != "MALE" && a_gender.ToUpper() != "FEMALE")
            {
                Console.WriteLine("Please enter a valid gender!");
            }
            else
            {
                gender = a_gender;
            }
            age = a_age;
        }

        public Person() { }
    }
}
