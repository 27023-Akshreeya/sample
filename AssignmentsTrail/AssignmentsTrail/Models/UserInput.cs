using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentsTrail.Repository;
using AssignmentsTrail.Service;

namespace AssignmentsTrail.Models
{
    public class UserInput
    {
        public void GetInput()
        {
            CheckValidity strval = new CheckValidity();

            Console.WriteLine("Enter your name");
            string? name=Console.ReadLine();
            strval.CheckStrValidity(name);

            Console.WriteLine("Enter your Phone number");
            long phoneNumber= Convert.ToInt64(Console.ReadLine()); 
            strval.CheckNumValidity(phoneNumber);

            Console.WriteLine("Enter your email address");
            string? emailAddress=Console.ReadLine();
            strval.CheckEmailValidity(emailAddress);

            Console.WriteLine("Enter additional notes");
            string? addNotes=Console.ReadLine();
            strval.CheckNoteslValidity(addNotes);

            ContactInfo contact = new ContactInfo(name,phoneNumber,emailAddress,addNotes);
            ContactManager con = new ContactManager();
            con.Add(contact);
        }
    }
}
