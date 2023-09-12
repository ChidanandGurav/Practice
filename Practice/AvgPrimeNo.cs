using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class AvgPrimeNo
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            int sum = 0;
            int count = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter No.");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < arr.Length; i++)
            {
                bool isPrime = true;
                for(int j = 2; j < arr[i]; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if(isPrime)
                {
                    Console.WriteLine(arr[i]);
                    sum = sum + arr[i];
                    count++;
                }
            }
            double avg = (double)sum / count;
            Console.WriteLine("Avg of Prime No :" +avg);
        }
    }
}
