using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class fandL_Sum
    {
        static void Main(string[] args)
        {
          int sum = 0;
            int FirstDigit;
            int LastDigit;
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());

             LastDigit = num % 10;
             FirstDigit = num;
            

            while(num > 10)
            {
              num = num / 10;
            }

            FirstDigit = num;
            sum = FirstDigit + LastDigit;
            Console.WriteLine("Sum of 1st and last Number :" +sum);

      
        }
    }
}
