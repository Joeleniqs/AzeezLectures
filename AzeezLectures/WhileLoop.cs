using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzeezLectures
{
    public class WhileLoop
    {
        public void WhileLoopSample()
        {
            Repeat:
            Console.WriteLine("Supply Buzz Range:");
            Int32.TryParse(Console.ReadLine(), out int rangeNumber);
            if (rangeNumber == 0)
            {
                goto Repeat;
            }
            int startNumber = 1;
            while (/* Condition */startNumber <= rangeNumber) {
                //action
                Console.WriteLine(startNumber);
                //increment 
                startNumber++;
            }
        }
    }
}
