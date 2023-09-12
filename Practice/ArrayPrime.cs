using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice
{
    public class ArrayPrime
    {

        //WAC to display prime element from the array
        static void Main(string[] args)
        {
            int[] array = new int[10];
            
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter Number");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < array.Length ; i++)
            {
                int Count = 0;
                for(int j = 2; j < array[i]; j++)
                {
                    if (array[i] % j == 0)
                    {
                        Count++;
                        break;
                    }
                }

                if (Count == 0)
                {
                    Console.WriteLine("Prime Number is :" + array[i]);
                }
            }
            
        }
    }
}
