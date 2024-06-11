using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自製List
{
    internal class Node<T>
    {
        public T Body { get; set; }
        public Node<T> Next { get; set; }

        public Node(T s) 
        {
            this.Body = s;
        }
    }
}
