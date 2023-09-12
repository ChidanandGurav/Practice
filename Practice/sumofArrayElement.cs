using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class sumofArrayElement
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            int sum = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine(sum);
        }
    }
}
