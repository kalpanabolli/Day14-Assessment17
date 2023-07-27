using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the radius of the circle:");
            double circleRadius = double.Parse(Console.ReadLine());
            Circle circle = new Circle(circleRadius);

            Console.WriteLine("Enter the width of the rectangle:");
            double rectangleWidth = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height of the rectangle:");
            double rectangleHeight = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(rectangleWidth, rectangleHeight);

            Console.WriteLine("Enter the length of side A of the triangle:");
            double sideA = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of side B of the triangle:");
            double sideB = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of side C of the triangle:");
            double sideC = double.Parse(Console.ReadLine());
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            Console.WriteLine("Circle Info:");
            circle.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Rectangle Info:");
            rectangle.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Triangle Info:");
            triangle.PrintInfo();
            Console.ReadKey();
        }
    }
}