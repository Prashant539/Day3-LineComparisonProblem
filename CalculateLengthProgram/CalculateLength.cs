using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLengthProgram
{
    public class CalculateLength
    {
        public void CheckLength()
        {
            int x1 = 4;
            int x2 = 5;
            int y1 = 6;
            int y2 = 7;

            double lengthOfLine1 = Math.Sqrt(((x2 - x1) ^ 2) + ((y2 - y1) ^ 2));
            Console.WriteLine("The points x1 = " + x1);
            Console.WriteLine("The points x2 = " + x2);
            Console.WriteLine("The points y1 = " + y1);
            Console.WriteLine("The points y2 = " + y2);
            

        }


    }
}   
   

