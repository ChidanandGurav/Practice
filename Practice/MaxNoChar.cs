using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class MaxNoChar
    {
        static void Main(string[] args)
        {
            char[] ch = new char[5];
            char max = ch[0];

            for(int i = 0; i < ch.Length; i++)
            {
                Console.WriteLine("Enter Character");
                ch[i] = Convert.ToChar(Console.ReadLine());
            }

            for(int i = 0; i < ch.Length;i++)
            {
                if (ch[i] > max)
                {
                    max = ch[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
