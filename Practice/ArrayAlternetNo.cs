using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{

    // WAC to display alternate element from the array
    public class ArrayAlternetNo
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int sum = 0;

            /*for(int i = 0; i < arr.Length; i+=2)
            {
                Console.WriteLine(arr[i]);
            }*/

            for (int i = 0; i < arr.Length; i += 2)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);        }
    }
}
