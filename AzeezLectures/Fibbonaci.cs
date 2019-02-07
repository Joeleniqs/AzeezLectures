using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzeezLectures
{
    public class Fibbonaci
    {
        public void CalculateFibbonaci()
        {
            Repeat:
            Console.WriteLine("Please Supply Fibbonachi range: \n Or Type Exit to close application");
            var input = Console.ReadLine();
            if (input.ToLower() == "exit")
            {
                Environment.Exit(0);
            }
            else
            {
                Int32.TryParse(input, out int number);
                if (number == 0)
                {
                    goto Repeat;
                }
           
            int[] F = new int[number];
            F[0] = 1;
            F[1] = 1;
            for (int i = 0; i < number; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"F({i + 1}) is {F[0]}");

                }
                else if (i == 1)
                {
                    Console.WriteLine($"F({i + 1}) is {F[1]}");

                }
                else
                {
                    F[i] = F[i - 1] + F[i - 2];
                    Console.WriteLine($"F({i + 1}) is {F[i]}");

                }
            }
            }
            goto Repeat;
            
        }

    }
}
