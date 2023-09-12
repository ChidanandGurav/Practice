using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //1.	Write a java program to find nth lowest number in an array/arraylist.
    //N is less than (length of array – 1)
    public class LowestNo
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int Min = int.MaxValue;

            for(int i =0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter a Number");
                int num = Convert.ToInt32(Console.ReadLine());

                if(num < Min)
                {
                    Min = num;
                }
            }
            Console.WriteLine("Minimum No in Array :"+Min);

        }
    }
}
