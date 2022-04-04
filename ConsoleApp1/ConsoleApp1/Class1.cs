using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l_2_t_2
{
    public class Class1
    {
        public static double check(double x, double y)
        {
            if (y > Math.Abs(x) && y * y + x * x < 225)
            {
                return 1;
            }
            else if (y >= Math.Abs(x) && y * y + x * x <= 225)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
