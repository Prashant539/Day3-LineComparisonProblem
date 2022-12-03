using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCompareProgram
{
    public class CompareLine
    {
        public void ComparingLines()
        {
            int x1 = 3;
            int x2 = 6;
            int y1 = 3;
            int y2 = 7;
            int x3 = 8;
            int y3 = 9;
            int x4 = 3;
            int y4 = 2;

            if (x2 == x4 && y2 == y4)
            {
                Console.WriteLine("The two lines are equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }



        }
    }
}
    

