using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Revise
{
    internal class Student : Person
    {
        public string student_name { get; set; }
        public int student_id { get; set; }

        public Student (string a_student_name, int a_student_id, int a_age, string a_gender) : base(a_age, a_gender)
        {
            student_name = a_student_name;
            student_id = a_student_id;
        }

        public Student() { }

    }
}
