using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class _1stLastSum
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num=Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int sum = 0, cnt = 0;

            while(num!=0)
            {
                int rem=num%10;
                cnt++;
                num = num / 10;
            }

            while(temp!=0)
            {
                int rem=temp%10;
                for (int i = 1; i <= cnt; i++)
                {
                    if (i == 1|| i == cnt)
                    {
                        sum = sum + rem;
                    }
                    
                }
                temp = temp / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
