using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自製List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //list2.Add(20);
            //list2.RemoveAt(3);
            LinkList list = new LinkList
            {
                "A",
                "B",
                "D"
            };

            LinkList list2 = new LinkList();
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

            Console.ReadKey();
        }
    }
}
