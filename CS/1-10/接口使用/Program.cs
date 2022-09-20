using System;

namespace 接口使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //实现多态
            IKouLan kl = new Student();
            kl.KouLan();
            Console.ReadKey();
        }
    }

    class Person
    {
        public void CHLSS()
        {
            Console.WriteLine("人类可以吃喝");
        }
    }
    class Student:Person,IKouLan
    {
        public void KouLan()
        {
            Console.WriteLine("学生可以扣篮");
        }
    }
    interface IKouLan
    {
        void KouLan();
    }
    class NBAPlayer:Person
    {
        public void KouLan()
        {
            Console.WriteLine("NBA球员可以扣篮");
        }
    }
}
