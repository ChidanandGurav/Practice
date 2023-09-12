using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Ass4
    {
        //WAP to create jagged array, initialized data & display the details

        static void Main(string[] args)
        {
            int[][] arr = new int[4][];
            arr[0] = new int[] {1,2,3,4};
            arr[1] = new int[] { 5, 6, 7, };
            arr[2] = new int[] { 8, 9 };
            arr[3] = new int[] { 10 };

            for (int row = 0; row<arr.Length; row++)
            {
                for(int col = 0; col < arr[row].Length; col++)
                {
                    Console.Write(arr[row][col] + " ");
                }
                Console.WriteLine("\n");
            }

        }
    }
}
