using System;

namespace AreaOfACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi;
            pi = 3.14;
            double radius;
            double area;
            double circumference;
            double diameter;
            double mpg;
            double gallons;
            string input;

            Console.WriteLine("Enter a radius of a circle:");
            input = Console.ReadLine();
            radius = double.Parse(input);

            area = pi * radius * radius;
            circumference = 2 * pi * radius;
            diameter = 2 * radius;

            Console.WriteLine("The area of a circle of radius " + radius + " is: " + area);
            Console.WriteLine("The circumference of a circle of radius " + radius + " is: " + circumference);
            Console.WriteLine("The diameter of a circle of radius " + radius + " is: " + diameter);

            Console.WriteLine("Enter the miles per gallon of your car:");
            input = Console.ReadLine();
            mpg = double.Parse(input);
            gallons = mpg / radius;

            Console.WriteLine("If the radius you entered was in miles, you would use " + gallons + " gallons of gas around the circle.");
            Console.ReadLine();
        }
    }
}
