using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //Find the sum of digit from the string
    public class B_stringSumdigit
    {
        static void Main(string[] args)
        {
            string str = "12345";
            int sum = 0;
            char[] ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] > '0' && ch[i] < '9' )
                {
                    int x = (int)(char.GetNumericValue(ch[i]));
                    sum = sum+ x;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
