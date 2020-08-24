using System;

namespace OperatorsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
          //explicit typing -
          string variableName = "Hello";
          //inferred typing - best practice
          var varName = "Hello";

            Console.WriteLine($"{variableName}");

            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");

            //Allow user to input the radius
            Console.WriteLine("Input your circles radius to find the area");
            var radius = double.Parse(Console.ReadLine());

            //Calculate the area of the circle
            var areaOfCircle = CalculateArea(radius);

            Console.WriteLine($"The area of a circle with a radius of {radius} is {areaOfCircle}");
        }

        public static double CalculateArea(double radius)
        {
            return Math.PI * (radius * radius);
        }
    }
}
