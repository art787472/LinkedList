using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自製List
{
    static internal class Extension
    {
        public static LinkList<T1> Select<T,T1>(this LinkList<T> list, Func<T, T1> func) 
        {
            LinkList<T1> res = new LinkList<T1>();
            foreach(T item in list)
            {
                res.Add(func(item));
            }
            return res;
        }

        public static LinkList<T> Where<T>(this LinkList<T> list, Func<T, bool> func) 
        {
            LinkList<T> res = new LinkList<T>();
            foreach(T item in list)
            {
                if (func(item)) { res.Add(item); }
            }
            return res;
        }

        public static T FirstOrDefault<T>(this LinkList<T> list, Func<T, bool> func)
        {
            foreach(T item in list) 
            {
                if (func(item))
                    return item;
            }
            return default(T);
        }

        public static T LastOrDefault<T>(this LinkList<T> list, Func<T, bool> func)
        {
            T target = default(T);

            foreach(T item in list)
            {
                if(func(item))
                    target = item;
            }
            return target;
        }

        public static bool Any<T>(this LinkList<T> list, Func<T, bool> func) 
        {
            foreach(T item in list)
            {
                if(func(item))
                    return true;
            }
            return false;
        }

        public static bool All<T>(this LinkList<T> list, Func<T, bool> func)
        {
            foreach(T item in list)
            {
                if(!func(item))
                    return false;
            }
            return true;
        }

        public static int Sum<T>(this LinkList<T> list, Func<T, int> func)
        {
            int res = 0;
            foreach(T item in list)
            {
                res += func(item);
            }
            return res;
        }

        public static int Count<T>(this LinkList<T> list, Func<T, bool> func)
        {
            int cnt = 0;
            foreach(T item in list)
            {
                if (func(item))
                    cnt++;
            }
            return cnt;
        }
        


    }
}
