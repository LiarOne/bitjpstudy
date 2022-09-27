using System;
using System.Collections.Generic;

namespace _09List泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            //集合--->数组
            //Count:获取集合中实际包含的个数
            //Capacity:获取集合中能够容纳的元素个数
            //int[] numbers = new int[10];
            //list.Add(1);
            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Capacity);
            //Add是添加单个元素
            //AddRange是添加集合
            list.Add(100);
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6 });

            Console.ReadKey();
        }
    }
}
