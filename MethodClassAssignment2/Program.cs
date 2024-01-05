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
            
            //Define the integer
            int firstInteger = 5,
            int secondInteger = 10;

            //Call the MathOps method with the integers
            operation.MathOps(firstInteger, secondInteger);    
        }
    }
}
