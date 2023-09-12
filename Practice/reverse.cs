using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class reverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            int rev = 0;

          while(num != 0)
            {
                int rem = num % 10;
                num = num / 10;
                rev = ((rev * 10) + rem);
            }

            Console.WriteLine("Number After Reverse : " + rev);
        }
    }
}
