using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the class
            MathOperation mathOperation = new MathOperation();

            // Calling the method in the class, passing in two numbers
            mathOperation.PerformMathOperation(31, 24);

            // Calling the method in the class, specifying the parameters by name
            mathOperation.PerformMathOperation(number1: 18, number2: 20);

            Console.ReadLine();
        }
    }
}
