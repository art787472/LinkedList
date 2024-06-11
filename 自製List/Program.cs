using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace 自製List
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //list2.Add(20);
            //list2.RemoveAt(3);
            LinkList<string> list = new LinkList<string>();
            list.Add("A");
            list.Add("B");
            list.Add("D");

            LinkList<string> list2 = new LinkList<string>();
            list2.Add("B");
            list2.Add("D");

            list.AddRange(list2);
            //Console.WriteLine(list[0]);
            //Console.WriteLine(list[1]);
            //Console.WriteLine(list[2]);
            //Console.WriteLine(list[3]);

            //  IEnumerator / IEnumerable / IQueryable => 這三個是甚麼東西? 用途?

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            LinkList<string> result = list.Select(x => x + "!");
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }

            foreach (string item in result.Where(x => x.Contains("B")))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(result.All(x => x.Contains("!")));
            Console.WriteLine(result.Any(x => x.Contains("E")));

            Console.WriteLine(result.FirstOrDefault(x => x.Contains("A")));
            Console.WriteLine(result.LastOrDefault(x => x.Contains("E")));

            Console.WriteLine(result.Sum(x => x.Length));
            Console.WriteLine(result.Count(x => x.Contains("B")));
            Console.ReadKey();
        }
    }
}
