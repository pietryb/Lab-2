using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the room calculator");

            Console.WriteLine("What is the length of the room?");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the length of the room?");
            double width = double.Parse(Console.ReadLine());

            double area = width * length;
            double perimeter = (width + length);
            double paint = perimeter / 5;
            double carpet = area / 5;

            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimeter: {perimeter}");
            Console.WriteLine($"Paint: {paint}");
            Console.WriteLine($"Carpet: {carpet}");


        }
    }
}
