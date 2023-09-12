using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{

    //WAP to sort an array in Descending order.
    public class D_ArryDesending
    {
        static void Main(string[] args)
        {
            int[] Dec = { 1, 2, 3, 4, 5, 6 };

            for(int i=0; i<Dec.Length; i++)
            {
                for(int j = 0; j < Dec.Length; j++)
                {
                    if (Dec[i] > Dec[j])
                    {
                        int temp = Dec[i];
                        Dec[i] = Dec[j];
                        Dec[j] = temp;
                    }
                }
            }

            foreach(int i in Dec)
            {
                Console.WriteLine("Descending OrderList:" + i);
            }
        }
    }
}
