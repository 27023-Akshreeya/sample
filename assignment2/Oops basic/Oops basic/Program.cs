using System;
using Oops_basic.View;

namespace Oops_basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserConsole userConsole = new UserConsole();
            Console.WriteLine("Execution starts!");
            var rectangleDetails = userConsole.GetRectangleDetails();
            int area = (int)(rectangleDetails.Length * rectangleDetails.Width);
            Console.WriteLine($"shape name:{rectangleDetails.shapeName}\nColor:{rectangleDetails.Color}\nArea:{area}");
            Console.ReadLine();
        }
    }
}
