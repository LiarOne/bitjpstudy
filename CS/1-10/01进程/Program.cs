using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _01进程
{
    class Program
    {
        static void Main(string[] args)
        {
            //存储当前正在运行的进程
            //Process[] pro = Process.GetProcesses();
            //foreach (var item in pro)
            //{
            //    //item.Kill();
            //    Console.WriteLine(item.ProcessName);
            //}
            //Process.Start("notepad"); //打开记事本
            //Process.Start("mspaint"); //打开画图工具
            //Process.Start("iexplore","http://www.baidu.com"); //打开网页
            //Process.Start("cals"); //打开计算器

            //使用进程打开文件

            //封装要打开的文件，并不打开这个文件
            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\wzh\Desktop\问题.txt");
            //创建进程对象
            Process pro = new Process();
            //告诉进程要打开的文件信息
            pro.StartInfo = psi;
            //调用函数打开
            pro.Start();
            Console.ReadKey();
        }
    }
}
