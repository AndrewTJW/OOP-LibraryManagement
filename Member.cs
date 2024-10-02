using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Revise
{
    internal class Member : Student
    {
        public string Member_ID { get; set; }

        public Member (string a_member_id, string a_student_name, int a_student_id, int a_age, string a_gender ) : base(a_student_name, a_student_id, a_age, a_gender)
        {
            Member_ID = a_member_id;
        }

        public Member() { }
    }
}
