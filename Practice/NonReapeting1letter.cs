using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{

    //3.	Find first non-repeating letter in the  given string. 
    //e.g.  Input string is ‘My Name is Yasmin’. First non-repeating string is ‘e’. 

    internal class NonReapeting1letter
    {
        static void Main(string[] args)
        {
            string str = "my name is yasmin";
            
            char[] ch = str.ToCharArray();
            

            for(int i =0; i < ch.Length; i++)
            {
                int cnt = 0;
                for (int j = 0; j<ch.Length; j++)
                {
                    if (ch[i] == ch[j])
                    {
                        cnt++;
                    }
                }
                if(cnt == 1)
                {
                    Console.WriteLine(ch[i]);
                }
            }
            
        }
    }
}
