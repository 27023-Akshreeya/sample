using AssignmentsTrail.Models;
using AssignmentsTrail.Service;

namespace AssignmentsTrail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("MENU");
            Console.WriteLine("[A]dd contact");
            Console.WriteLine("[S]earch contact");
            Console.WriteLine("[V]iew all contact");
            Console.WriteLine("[E]dit contact");
            Console.WriteLine("[R]emove contact");
            Console.WriteLine("[C]lose contact");
            Console.WriteLine("------------------");

            Console.Write("Enter you choice:");
            string? inputstr = Console.ReadLine();

            if (inputstr == null || inputstr == "")
            {
                Console.WriteLine("Invalid string");
            }
            if (char.TryParse(inputstr, out char res))
            {
                Console.WriteLine($"Option choosen: {res}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter exactly one charecter of your Option");
            }

            Console.WriteLine();
            char inp = Convert.ToChar(inputstr);

            ContactManager contactManager = new ContactManager();
            UserInput userInput = new UserInput();  
            switch (inp)
            {
                case 'A' or 'a':
                    userInput.GetInput();
                    break;
                case 'S' or 's':
                    Console.WriteLine();
                    break;
                case 'V' or 'v':
                    Console.WriteLine();
                    break;
                case 'E' or 'e':
                    Console.WriteLine();
                    break;
                case 'R' or 'r':
                    Console.WriteLine();
                    break;
                case 'C' or 'c':
                    break;
            }

        }
    }
}
