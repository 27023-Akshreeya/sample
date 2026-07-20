using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Oops_basic.Model;

namespace Oops_basic.View
{
    public class UserConsole
    {
        public void Menu()
        {
            bool exit = false;
            while (exit)
            {
                Console.WriteLine("Select the shape to calculate area: \n1. Rectangle\n2. Circle\n3. Exit\nEnter you option:");

                string choice = Console.ReadLine();
                if (!Helper.IsChoiceValid(choice))
                {
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    exit =true;
                }
                switch(choice)
                {
                    case "1":
                        RectangleInfo rectangle = GetRectangleDetails();
                        var methodChoice = GetMethodChoice();

                        break;
                    case "2":
                        CircleInfo circle = GetCircleDetails();
                        var methodChoiceCircle = GetMethodChoice();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }

        private CircleInfo GetCircleDetails()
        {
            Console.WriteLine("Enter the color of the circle:");
            var color = Console.ReadLine();
            if (!Helper.IsColorValid(color))
            {
                Console.WriteLine("Invalid color. Please enter a valid color.");
                return GetCircleDetails();
            }
            Console.WriteLine("Enter the radius of the circle:");
            var radiusInput = Console.ReadLine();
            if (!Helper.IsDimensionValid(radiusInput))
            {
                Console.WriteLine("Invalid radius. Please enter a positive number.");
                return GetCircleDetails();
            }
            int radius = (int)Convert.ToDouble(radiusInput);
            CircleInfo shapeInfo = new CircleInfo("Circle", color, radius);
            return shapeInfo;
        }

        //ShapeInfo rectangle = new ShapeInfo();
        public RectangleInfo GetRectangleDetails()
        {
            Console.WriteLine("Enter the color of the rectangle:");
            var color = Console.ReadLine();
            if (!Helper.IsColorValid(color))
            {
                Console.WriteLine("Invalid color. Please enter a valid color.");
                return GetRectangleDetails();
            }
            Console.WriteLine("Enter the length of the rectangle:");

            var lengthInput = Console.ReadLine();
            if(!Helper.IsDimensionValid(lengthInput))
            {
                Console.WriteLine("Invalid length. Please enter a positive number.");
                return GetRectangleDetails();
            }
            int length = (int)Convert.ToDouble(lengthInput);

            Console.WriteLine("Enter the height of the rectangle:");
            var heightInput = Console.ReadLine();
            if (!Helper.IsDimensionValid(heightInput))
            {
                Console.WriteLine("Invalid height. Please enter a positive number.");
                return GetRectangleDetails();
            }
            int height = (int)Convert.ToDouble(heightInput);

            RectangleInfo shapeInfo = new RectangleInfo("Rectangle", color, length, height);
            return shapeInfo;
        }

        public string GetMethodChoice()
        {
            Console.WriteLine("Select an option to perform:");
            Console.WriteLine("1. Calculate Area\n2.Print Details\nEnter you choice:");
            string choice = Console.ReadLine();
            if (!Helper.IsChoiceValid(choice))
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
                return GetMethodChoice();
            }
            return choice;
        }
    }
}
