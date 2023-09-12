using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class A_MaxNumber
    {
        //Find the Max Number from array
        static void Main(string[] args)
        {
            int[] Array = new int[5];
            int max = 0;

            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("Enter a Number");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num > max)
                {
                    max = num;
                }
            }

            Console.WriteLine("Maximum Number is : " + max);
        }
    }
}
