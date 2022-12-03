using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCompare
{
    public class CompareTwoLine
    {
        public void MethodCompare()
        {
            int x1 = 3;
            int x2 = 5;
            int y1 = 7;
            int y2 = 9;
            int x3 = 2;
            int y3 = 1;
            int x4 = 5;
            int y4 = 9;

            if (x2 == x4 && y2 == y4)
            {
                Console.WriteLine("The line is equal");
            }
            else if (x1 >= x3)
            {
                Console.WriteLine("The first line greater than the other line");
            }
            else
            {
                Console.WriteLine("The line is less than other line");
            }


        }
    }
}
   

