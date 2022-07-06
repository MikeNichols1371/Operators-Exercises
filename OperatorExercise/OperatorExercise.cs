using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    internal class OperatorExercise2
    {
        public static int Add(int z, int y)
            { return z + y; }
        public static int Subtract(int c, int d)
            { return c - d; }
        public static int Multiply(int e, int f)
            { return e * f; }
        public static int Divide(int a, int b)
            {
            int quotiant = a / b;
            int remainder = a % b;
            string ab = (a == 17 && b == 4) ? $"{a}/{b}={quotiant} remainder {remainder}" : "Default message";
            Console.WriteLine(ab);
                return a / b; }
        public static int Modulus(int i, int j)
            { return i % j; }
      
        
        

        
    }
}
