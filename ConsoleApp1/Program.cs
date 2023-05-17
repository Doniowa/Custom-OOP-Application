using System;

namespace PaintCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Paint calculator");
            Console.WriteLine("-----------------");

            Console.Write("Enter the length of the room (in meters): ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the width of the room (in meters): ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height of the room (in meters): ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number of windows: ");
            int windowCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of doors: ");
            int doorCount = Convert.ToInt32(Console.ReadLine());

            // Calculation of the area of walls 
            double wallArea = 2 * (length + width) * height - windowCount * 2.4 - doorCount * 1.8;

            // Calculation of liters 
            double paintRequired = wallArea / 10;

            Console.WriteLine("-----------------");
            Console.WriteLine("To paint the room you need: " + paintRequired + "liters of paint.");

            Console.ReadLine();

            //Calculation of cost 
            Console.WriteLine("Cost");
            double cost = 30 * paintRequired;
            Console.WriteLine("to paint a room you have to spend " + cost + " pln");
        }
    }
}
