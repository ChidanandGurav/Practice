using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Factors
    {
        int fact = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no");
            int Num = Convert.ToInt32(Console.ReadLine());
            if (Num % 2 == 0)
            {
                for (int i = 1; i < Num; i++)
                {
                    if (Num % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine(Num * Num);
            }

        }
    }
}
