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

            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");
        }
    }
}
