using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class ArrayNoSearch
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Enter a Number");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

                Console.WriteLine("Enter a Search Number");
                int a = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i<num.Length; i++ )
                {
                    if (num[i] == a)
                    {
                        Console.WriteLine(a + "Is a Found Number at Index "+ i ) ;
                    }
                   else
                   {
                    Console.WriteLine("It is Found");
                   }
                }
            
        }
    }
}
