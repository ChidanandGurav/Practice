using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class _1stMockTest
    {
        static void Main(string[] args)
        {
            int sum = 0;

            
           for (int i = 1; i <= 20; i++)    
            {
                bool isprime = true;
                for (int j= 2; j<i; j++)
                {
                    if(i % j == 0)
                    {
                        isprime= false;
                        break;
                    }
                }
                if (isprime == true)
                  
                {
                    Console.WriteLine(i);
      
                    sum = sum + i;
                }
                
           }
            Console.WriteLine("Sum of Prime Number : "+sum);

        }
    }
}
