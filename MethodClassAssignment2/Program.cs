using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment2
{
    public class Program
    {
        public void Main(string[] args)
        {
            //Instantiate Operation class
            Operation operation = new Operation();
            int firstInteger = 5;
            int secondInteger = 10;
            operation.MathOps(firstInteger, secondInteger);
            operation.MathOps(num1: 7, num2: 15);
               
        }
    }
}
