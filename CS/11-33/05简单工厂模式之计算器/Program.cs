using System;

namespace 简单工厂模式之计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入第一个数字");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入第二个数字");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入操作符");
            string oper = Console.ReadLine();
            //根据用户输入的操作符，返回计算符的父类
            Operation operation = GetOperation(oper, n1, n2);
            if(operation!=null)
            {
                int result = operation.GetResult();
                Console.WriteLine("{0}{1}{2}={3}", n1, oper, n2, result);
            }
            else
            {
                Console.WriteLine("没有该运算符");
            }
            Console.ReadKey();
        }
        static Operation GetOperation(string oper,int n1,int n2)
        {
            Operation operation = null;
            switch(oper)
            {
                case "+":
                    operation = new Add(n1, n2);
                    break;
                case "-":
                    operation = new Sub(n1, n2);
                    break;
            }
            return operation;
        }
    }
}
