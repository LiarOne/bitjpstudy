using System;
using System.Collections.Generic;

namespace 索引器使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(nums[2]);
            //Dictionary<string, int> dic = new Dictionary<string, int>();
            //dic.Add("张三", 100);
            //dic.Add("李四", 80);
            Person p = new Person();
            //p.Numbers = new int[] { 1, 2, 3, 4, 5 };
            p[0] = 1;
            p[1] = 2;
            p[2] = 3;
            p[3] = 4;
            for (int i=0;i<p.Numbers.Length;i++)
            {
                Console.WriteLine(p.Numbers[i]);
            }
            Console.ReadKey();
        }
    }

    class Person
    {
        private int[] numbers = new int[5];
        public int[] Numbers
        {
            get { return numbers; }
            set { numbers = value; }
        }
        //索引器 让对象以索引的方式操作数组
        public int this[int index]
        {
            get { return numbers[index]; }
            set { numbers[index] = value; }
        }
        Dictionary<string, string> dic = new Dictionary<string, string>();
        public string this[string index]
        {
            get { return dic[index]; }
            set { dic[index] = value; }
        }
    }
}
