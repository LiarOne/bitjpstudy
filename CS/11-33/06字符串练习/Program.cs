using System;
using System.IO;
using System.Text;

namespace 字符串练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //1、输入字符串以相反顺序输出
            //string str = "abcdef";
            //char[] chs = str.ToCharArray();
            //for(int i=0;i<chs.Length/2;i++)
            //{
            //    char temp = chs[i];
            //    chs[i] = chs[chs.Length - 1 - i];
            //    chs[chs.Length - 1 - i] = temp;
            //}
            //str=new string(chs);
            //Console.WriteLine(str);
            //Console.ReadKey();

            //2、输入的一句英文，将每个单词以反序输出
            //string str = "I love you";
            //string[] strNew = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //for(int i=0;i<strNew.Length;i++)
            //{
            //    char[] chs=strNew[i].ToCharArray();
            //    for(int j=0;j<chs.Length/2;j++)
            //    {
            //        char temp = chs[j];
            //        chs[j] = chs[chs.Length - 1 - j];
            //        chs[chs.Length - 1 - j] = temp;
            //    }
            //    strNew[i] = new string(chs);
            //}
            //str = string.Join(" ", strNew); //字符串数组每个元素后插入一个空格
            //Console.WriteLine(str);
            //Console.ReadKey();

            //3、日期字符串中把年月日分别取出打印
            //string date = "2012年12月21日";
            //string[] newDate = date.Split(new char[] { '年', '月', '日' },StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0}年{1}月{2}日", newDate[0], newDate[1], newDate[2]);
            //Console.ReadKey();

            //4、csv文件中联系人姓名和电话显示出来
            //string[] lines = File.ReadAllLines(@"C:\User\wzh\Desktop\电话.txt", Encoding.Default);
            //for(int i=0;i<lines.Length;i++)
            //{
            //    //双引号替换成“”
            //    lines[i] = lines[i].Replace("\"", "");
            //    //去掉逗号和分号
            //    string[] linesNew = lines[i].Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            //    Console.WriteLine("姓名：" + linesNew[0] + linesNew[1] + "电话：" + linesNew[2]);
            //}
            //Console.ReadKey();

            //5、123-456---7---89-----123----2 把字符串中重复符号“-”去掉，即得到123-456-7-89-123-2
            //string str = "123-456---7---89-----123----2";
            //string[] strNew = str.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(string.Join("-", strNew));
            //Console.ReadKey();


        }
    }
}
