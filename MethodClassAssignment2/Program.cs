using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Operation class
            Operation operation = new Operation();
            //Ask user to enter an integer
            int num1 = Convert.ToInt32(Console.ReadLine());

            //user will now enter value displayed above(num2)
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            
        }
    }
}
