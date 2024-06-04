using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自製List
{
    internal class Node
    {
        public string Body { get; set; }
        public Node Next { get; set; }

        public Node(string s) 
        {
            this.Body = s;
        }
    }
}
