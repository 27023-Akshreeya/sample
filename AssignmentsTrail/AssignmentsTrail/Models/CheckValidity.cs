using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AssignmentsTrail.Models
{
    public class CheckValidity
    {

        public void CheckStrValidity(string str)
        {
            if (string.IsNullOrWhiteSpace(str) || !(str.All(char.IsLetter)))
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                return;
            }
        }
        public void CheckNumValidity(long num)
        {
            int length = num.ToString().Length;
            if (length != 10)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                return;
            }
        }
        public void CheckEmailValidity(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || !(email.All(char.IsLetter)))
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                return;
            }
        }
        public void CheckNoteslValidity(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                return;
            }
        }
    }
}