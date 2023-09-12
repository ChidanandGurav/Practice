using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //2.	There are 2 arrays of numbers. Find java program to find number
    //   in first array which is not in second array.
    public class Arr2
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = { 10, 11, 12, 13, 2, 4, 6 };
            

            for (int i=0; i<arr.Length; i++)
            {

                int cnt = 0;
                for (int j = 0; j<arr2.Length; j++)
                {
                    if (arr[i] == arr2[j])
                    {
                        cnt++; 
                    }
                }
                if (cnt == 0)
                {
                    Console.WriteLine(arr[i]);
                }
                
            }
            
        }
    }
}
