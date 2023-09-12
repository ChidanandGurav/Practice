using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //WAP to create an array of 5 strings to store students name, sort names in ascending order & display using foreach loop.

    public class Ass2
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Omkar");
            list.Add("Shreepad");
            list.Add("Bharat");
            list.Add("Rohan");
            list.Add("Akash");

            Console.WriteLine("Enter String Name");

            foreach(string s in list)
            {
                Console.WriteLine(s);
            }

            list.Sort();
            Console.WriteLine("Name Enetr as Asending Order");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
