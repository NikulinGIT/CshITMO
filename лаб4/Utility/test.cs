using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
   
        using System;

        /// <summary>
        /// This the test harness
        /// </summary>

        public class Test
        {
            public static void Main()
            {
                int x; // Input value 1
                int y; // Input value 2
                int greater; // Result from Greater()

                // Get input numbers
                Console.WriteLine("Enter first number:");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                y = int.Parse(Console.ReadLine());

                // Test the Greater( ) method
                greater = Utils.Greater(x, y);
                Console.WriteLine("The greater value is " + greater);

                Console.WriteLine("Before swap: " + x + "," + y);
                Utils.Swap(ref x, ref y);
                Console.WriteLine("After swap: " + x + "," + y);

        }
    }
    

}
