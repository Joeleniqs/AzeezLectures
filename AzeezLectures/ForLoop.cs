using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzeezLectures
{
    public class ForLoop
    {
        public void ForLoopSample()
        {
            Repeat:
            Console.WriteLine("Supply Buzz Range:");
            Int32.TryParse(Console.ReadLine(), out int rangeNumber);
            if (rangeNumber == 0)
            {
                goto Repeat;
            }

            for (int startNumber = 1; startNumber <= rangeNumber; startNumber ++)
            {
                if (startNumber % 5 == 0  && startNumber % 3 == 0 )
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if(startNumber % 5==0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(startNumber % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(startNumber);
                }
                
            }
        }
    }
}
