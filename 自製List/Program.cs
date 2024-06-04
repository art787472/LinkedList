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
            LinkList list = new LinkList();
            list.Add("A");
            list.Add("B");
            list.Add("D");

            LinkList list2 = new LinkList();
            list2.Add("B");
            list2.Add("D");

            list.RemoveRange(list2);
            //Console.WriteLine(list[0]);
            //Console.WriteLine(list[1]);
            //Console.WriteLine(list[2]);
            //Console.WriteLine(list[3]);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }


            list.Insert(4, "D");

            list.RemoveAt(2);

        }
    }
}
