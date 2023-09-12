using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //WAC to create array and display odd position element from the array
    public class ArrayOddPosElement
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter Number");
                arr[i] =Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.WriteLine("Odd Position Number :" + arr[i]);
                }
            }
        }
    }
}
