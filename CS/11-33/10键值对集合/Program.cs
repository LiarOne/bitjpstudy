using System;
using System.Collections.Generic;

namespace _10键值对集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> dic = new Dictionary<int, string>();
            //dic.Add(1, "张三");
            //dic.Add(2, "李四");
            //dic.Add(3, "王五");
            //dic.Add(4, "赵六");
            ////键必须唯一，值可以重复
            //dic[4] = "田七";
            //if(dic.ContainsKey(3))
            //{
            //    dic.Add(3, "狗蛋儿");
            //}
            //else
            //{
            //    dic[3] = "王狗蛋儿";
            //}
            ////使用foreach循环，对键值对集合进行遍历
            ////第一种，遍历键
            //foreach (int item in dic.Keys)
            //{
            //    Console.WriteLine("{0},{1}",item, dic[item]);
            //}
            ////第二种，遍历键值对
            //foreach (KeyValuePair<int,string> kv in dic)
            //{
            //    Console.WriteLine("{0},{1}",kv.Key,kv.Value);
            //}

            ////Console.WriteLine(dic[3]);
            //Console.ReadKey();


            //string str = "零0 一1 二2 三3 四4 五5 六6 七7 八8 九9";
            //Dictionary<char, char> dic = new Dictionary<char, char>();

            //string[] strNew = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //for(int i=0;i<strNew.Length;i++)
            //{
            //    dic.Add(strNew[i][0], strNew[i][1]);
            //}
            //Console.WriteLine("请输入小写：");
            //string input = Console.ReadLine();
            //for(int i=0;i<input.Length;i++)
            //{
            //    if(dic.ContainsKey(input[i]))
            //    {
            //        Console.Write(dic[input[i]]);
            //    }
            //    else
            //    {
            //        Console.Write(input[i]);
            //    }
            //}
            //Console.ReadKey();


            string str = "welcome, to chinaworld";
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i]==' '||str[i]==',')
                {
                    continue;
                }
                //如果字母第一次出现
                if(!dic.ContainsKey(str[i]))
                {
                    dic.Add(str[i], 1);
                }
                else
                {
                    //字母之前出现过
                    dic[str[i]]++;
                }
            }
            foreach (KeyValuePair<char,int> kv in dic)
            {
                Console.WriteLine("字母{0}出现了{1}次", kv.Key, kv.Value);
            }
            Console.ReadKey();
        }
    }
}
