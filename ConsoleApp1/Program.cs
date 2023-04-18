using System;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangles rectangle = new Rectangles();
            rectangle.Height = 5;
            rectangle.Width = 10;
            double rectangleArea = rectangle.Area();
            Console.WriteLine("L'aire du rectangle est : " + rectangleArea);

            Circles circle = new Circles();
            circle.Radius = 7;
            double circleArea = circle.Area();
            Console.WriteLine("L'aire du cercle est : " + circleArea);

            Square square = new Square();
            square.Height = 6;
            double squareArea = square.Area();
            Console.WriteLine("L'aire du carré est : " + squareArea);

            Triangle triangle = new Triangle();
            triangle.Base = 5;
            triangle.Height = 7;
            double triangleArea = triangle.Area();
            Console.WriteLine("L'aire du triangle est : " + triangleArea);

            Hexagonal hexagone = new Hexagonal();
            hexagone.Height = 7;
            double hexagoneArea = hexagone.Area();
            Console.WriteLine("L'aire de l'hexagone est : " + hexagoneArea);

            Shape[] arrShapes = new Shape[] { rectangle, circle, square, triangle, hexagone };
            AreaCalculator calculator = new AreaCalculator();
            double totalArea = calculator.TotalArea(arrShapes);

            Console.WriteLine("L'aire totale est : " + totalArea);
            Console.ReadLine();
        }
    }
}
