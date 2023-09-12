using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{  

    // Create a list and remove duplicate fom list.
    public class ClassExample1
    {
        static void Main(string[] args)
        {
          List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(1);
            list.Add(4);     
            list.Add(3);
            list.Add(5);
            list.Add(2);

           /* Console.WriteLine("Foreach Loop");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }*/
            Console.WriteLine("For Loop");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            for (int i = 0; i < list.Count; i++)
            { 
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        list.Remove(list[j]);
                        j--;
                    }
                }
            }

            Console.WriteLine("Ans After Remove");

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
