using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    internal class Utils
    {
        public static int Greater(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }


    }
}
