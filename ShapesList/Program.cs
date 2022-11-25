using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesList
{
    internal class Program
    {
        public static double validation(double num, String entry, String error)
        {
            do
            {
                try
                {
                    Console.WriteLine(entry);
                    num = Double.Parse(Console.ReadLine());
                    if (num <= 0)
                    {
                        Console.WriteLine(error);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input!");
                    num = 0;
                }
            } while (num <= 0);
            return num;
        }
        public static void perimetersSum(List<Shapes> shapes)
        {
            double parametersSum = 0;
            double side = 0;
            double perimeter = 0;

            foreach (Shapes shape in shapes)
            {
                shape.ShapeSidesNumber = 0;
                do
                {
                    shape.ShapeSidesNumber = validation(shape.ShapeSidesNumber, "Sides Number: ", "Enter a positive number!");
                    if (shape.ShapeSidesNumber < 3)
                    {
                        Console.WriteLine("There is no shape with " + shape.ShapeSidesNumber + " sides.");
                    }
                } while (shape.ShapeSidesNumber < 3);

                for (int i = 0; i < shape.ShapeSidesNumber; i++)
                {
                    side = validation(side, "Value of side " + (i + 1) + ":", "Enter a positive value!");
                    perimeter += side;
                }
                parametersSum += perimeter;
                perimeter = 0;
            }
            Console.WriteLine("Sum of perimeters: " + parametersSum);

        }
        static void Main(string[] args)
        {
            double shapesCount = 0;
            shapesCount = validation(shapesCount, "Shapes Number: ", "Enter a positive number!");
            List<Shapes> shapes = new List<Shapes>();

            for (int i = 0; i < shapesCount; i++)
            {
                Shapes shape = new Shapes();
                shapes.Add(shape);
            }

            perimetersSum(shapes);
        }
    }
}