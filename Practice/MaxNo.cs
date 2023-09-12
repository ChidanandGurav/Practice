using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //3.	There is array of numbers less than 10. Write a program to create maximum number by combining these numbers. 
     // e.g.  Array { 1 , 4, 9 ,2 , 5 } – output number should be  - 95421

    internal class MaxNo
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 9, 2, 5 };
            

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j<arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                
            }
            foreach(int ase in arr)
            {
                Console.Write(ase+" ");
            }
            Console.WriteLine();
        }
    }
}
