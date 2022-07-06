using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_a_circle
{
    internal class Area_of_a_circle2
    {
        public static double AreaOfCircle() 
        {
            Console.Write("Enter radius of circle: ");
            double radius = double.Parse(Console.ReadLine());
            var area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of this circle is: {Math.Round(area, 2)}");
            return area;
        }
    }
}
