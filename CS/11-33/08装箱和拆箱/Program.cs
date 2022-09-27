using System;
using System.Collections;
using System.Collections.Generic;

namespace _07装箱和拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList();
            //list.Add(100);
            //List<int> list = new List<int>();
            //for(int i=0; i<100000;i++)
            //{
            //    list.Add(i);
            //}
            int n = 10;
            object o = n; //装箱
            double d = (double)o; //拆箱

        }
    }
}
