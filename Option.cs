using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Revise
{
    internal class Option
    {
        private char user_option { get; set; }

        public Option (char a_user_option)
        {
            user_option = a_user_option;
        }

        

        public Option() { }

        public char getUserOption()
        {
            return user_option;
        }
    }
}
