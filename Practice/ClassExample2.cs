using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class ClassExample2
    {
        /*public static void ListFrequency(List<string> list)
        {
            Dictionary<string,int> d1 = new Dictionary<string,int>();
            for(int i=0; i<list.Count; i++)
            {
                int cnt = list[i].Count();
                d1.Add(list[i],cnt);
            }
            foreach(KeyValuePair<string,int> item in d1)
            {
                Console.WriteLine($"{item.Key} , {item.Value}");
            }
        }

        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "pune", "Mumbai", "pune" };
            foreach(string i in list)
            {
                Console.WriteLine(i);
            }
            ListFrequency(list);
        }*/

        static void Main(string[] args)
        {
            List<string> cityNames = new List<string>
            {
            "New York", "Los Angeles", "Chicago", "Houston", "New York", "Chicago", "Chicago", "Los Angeles"
            };

            // Using LINQ to find frequency of each element
            var frequency = cityNames.GroupBy(city => city)
                                     .Select(group => new { City = group.Key, Count = group.Count() });

            Console.WriteLine("City Name\tFrequency");
            Console.WriteLine("-----------------------");
            foreach (var item in frequency)
            {
                Console.WriteLine($"{item.City}\t\t{item.Count}");
            }
        }
    }

}
