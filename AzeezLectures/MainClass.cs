using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzeezLectures
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            WhileLoop initiator = new WhileLoop();
            ForLoop caller = new ForLoop();
            //initiator.WhileLoopSample();
            caller.ForLoopSample();
            Console.ReadLine();
        }
    }
}
