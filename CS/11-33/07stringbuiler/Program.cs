using System;
using System.Diagnostics;
using System.Text;

namespace stringbuiler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = string.Empty;
            //StringBuilder sb = new StringBuilder();
            //Stopwatch sp = new Stopwatch();
            //sp.Start();
            //for(int i=0;i<100000;i++)
            //{
            //    //str += i;
            //    sb.Append(i);
            //}
            //sp.Stop();
            //Console.WriteLine(sp.Elapsed);
            //Console.WriteLine(sb.ToString());
            StringBuilder sb = new StringBuilder();
            sb.Append("张三");
            sb.Append("李四");
            sb.Append("王五");
            sb.Insert(1, "新来的");
            sb.Replace("王五","***");
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
