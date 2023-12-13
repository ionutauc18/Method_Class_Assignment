using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment1
{
    internal class MathOperation
    {
        // Void method that takes two integers as parameters
        public void PerformMathOperation(int number1, int number2)
        {
            // Making a math operation using the first integer 
            int result = number1 * 5;

            // Displaying the second integer to the screen
            Console.WriteLine($"Math operation result: {result}, Second number: {number2}");
        }
    }
}
