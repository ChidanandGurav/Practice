using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{

    //WAP to reverse a string
    public class C_Reverse
    {
        static void Main(string[] args)
        {
            string str = "WelCome";

            char[] ch = str.ToCharArray();

            for(int i = ch.Length-1; i >= 0; i--)
            {
                Console.WriteLine(ch[i]);
            }
        }
    }
}
