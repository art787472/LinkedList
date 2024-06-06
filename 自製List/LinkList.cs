using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自製List
{
    internal class LinkList : IEnumerable, IEnumerator
    {
        public Node Head {  get; set; }
        private int count = 0;
        public int Count
        {
            get
            {
                return this.count;
            }
        }
        private int index = -1;
        
        public object Current => this[index];

        public LinkList() 
        {

        }

        public string this[int index]
        {
            get
            {
                if(index == 0)
                {
                    return Head.Body;
                }
                Node ptr = Head;

                while(index > 0)
                {
                    ptr = ptr.Next;
                    if(ptr.Next == null)
                    {
                        return ptr.Body;
                    }
                    index--;
                    
                }
                return ptr.Body;

            }
        }
        public void Add(string s)
        {
            this.count++;
            Node node = new Node(s);
            if(Head == null)
            {
                Head = node;
                
                return;
            }

            Node ptr = Head;

            while(ptr.Next != null)
            {
                ptr = ptr.Next;
            }

            ptr.Next = node;
        }

        public void Insert(int index, string s)
        {
            Node node = new Node(s);

            Node ptr = Head;
            index--;
            while (index > 0)
            {
                ptr = ptr.Next;
                if (ptr.Next == null)
                {
                    ptr.Next = node;
                    return;
                }
                index--;
            }

            Node temp = ptr.Next;
            ptr.Next = node;
            node.Next = temp;
            this.count++;
        }

        public void Remove(string s)
        {
            if (Head == null)
            {
                return;
            }
            if(Head.Body == s)
            {
                Head = Head.Next;
                this.count--;
                return;
            }

            Node ptr = Head;

            while(ptr.Next.Body != s)
            {
                ptr = ptr.Next;
                if (ptr.Next == null)
                    return;
            }

            ptr.Next = ptr.Next.Next;
            this.count--;

        }

        public void RemoveAt(int index)
        {
            Node ptr = Head;
            index--;
            while(index > 0)
            {
                ptr = ptr.Next;
                if (ptr.Next == null)
                    return;
                index--;
            }
            ptr.Next = ptr.Next.Next;
            this.count--;
        }

        public void AddRange(LinkList list)
        {
            if(Head == null)
            {
                this.Head = list.Head;
                return;
            }

            Node ptr = Head;
            while(ptr.Next != null)
            {
                ptr = ptr.Next;
            }

            ptr.Next = list.Head;
            this.count += list.Count;
        }

        public void RemoveRange(LinkList list)
        {
            for(int i = 0; i < list.count; i++)
            {
                this.Remove(list[i]);
                
            }
        }

        public bool MoveNext()
        {
            index++;
            return index < this.Count;

        }

        public void Reset()
        {
            index = -1;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }
}
