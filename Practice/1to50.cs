using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class _1to50
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Welcome to TQ :" + i);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("TQ :" + i);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Welcome :" + i);
                }

        }
    }
}
