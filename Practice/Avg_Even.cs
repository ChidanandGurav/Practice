using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Avg_Even
    {
        static void Main(string[] args)
        {
            int num=45623;
            int rem = 0;
            int sum = 0;
            int count = 0;

            while(num >0)
            {
                rem = num % 10;
                if(rem % 2 ==0)
                {
                    sum = sum + rem;
                    count++;
                }

                num = num / 10;
            }
           
            double avg = sum / count;
            Console.WriteLine(avg);
        }
    }
}
