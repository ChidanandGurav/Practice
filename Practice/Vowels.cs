using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Vowels
    {
        static void Main(string[] args)
        {
            char[] ch = new char[10];
            

            for(int i = 0; i < ch.Length; i++)
            {
                Console.WriteLine("Enter Character");
                ch[i] = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine("Vowels Are");
            for(int i = 0; i < ch.Length; i++)
            {
                if (ch[i]=='a' || ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u')
                {
                    Console.WriteLine(ch[i]);
                }
            }
        }
    }
}
