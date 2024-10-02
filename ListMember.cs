using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Revise
{
    internal class ListMember
    {
        List<Member> Members;

        public ListMember ()
        {
            Members = new List<Member>();
        }

        public void AddMemberToList (Member a_member)
        {
            Members.Add(a_member);
        }

        public void RemoveMemberFromList (Member a_member)
        {
            Members.Remove(a_member);
        }

        public Member findMemberById (string a_member_id)
        {
            for (int i = 0; i < Members.Count(); i++)
            {
                if (Members[i].Member_ID == a_member_id)
                {
                    return Members[i];
                }
            }
            return null;
        }

        public void DisplayMemberList ()
        {
            foreach (var a_member in Members)
            {
                Console.WriteLine("Name: {0}    ID: {1}",a_member.student_name, a_member.student_id);
            }
        }
    }
}
