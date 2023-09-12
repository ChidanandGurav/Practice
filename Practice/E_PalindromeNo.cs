using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;       

namespace Practice
{
    public class E_PalindromeNo
    {

        //.WAP to check given number is Palindrome or not
        static void Main(string[] args)
        {
            int num = 666;
            int rev = 0;
            int rem = 0;
            int temp = num;
            while(num != 0)
            {
                    rem = num % 10;
                    rev =((rev * 10) + rem);
                    num = num / 10;
            }
            Console.WriteLine("Revers No is:" +rev);

            if(temp == rev)
            {
                Console.WriteLine("Number is Palidrome");
            }
            else
            {
                Console.WriteLine("Number is Not Palidrome");
            }
        }
    }
}
