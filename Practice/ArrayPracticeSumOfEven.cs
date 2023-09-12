using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class ArrayPracticeSumOfEven
    {
        // WAC to create int type of array and calculate a sum of even element from the array
        static void Main(string[] args)
        {
            /*int[] Arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;

            for(int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] % 2 == 0)
                {
                    sum = sum + Arr[i];
                }
            }
            Console.WriteLine(sum);*/

            int[] Arr = new int[10];
            int sum = 0;

            for(int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine("Enter Number");
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < Arr.Length; i++)
            {

                if (Arr[i] % 2 == 0)
                {
                    sum = sum + Arr[i];
                }
            }
            Console.WriteLine(sum);

        }
    }
}
