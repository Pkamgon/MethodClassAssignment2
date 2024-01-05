using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment2
{
    public class Operation
    {
        //Create a class. In that class, create a void method that takes two integers as parameters.
        //Have the method do a math operation on the first integer and display the second integer to the screen.

        public  Operation(int num1, int num2) 
        {
            //Perform some math operation on the first integer
            num1 = num1 * 2;
            Console.WriteLine("The result of the operation on the first integer is:{num1}");
            Console.WriteLine("The second integer is:{num2}");
            
        }
    }
}
