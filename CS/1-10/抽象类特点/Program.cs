using System;

namespace 抽象类特点
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    abstract class Person
    {
        public abstract int SayHello(string name);
        //public abstract void Test();
    }
    class Student:Person
    {
        public override int SayHello(string name)
        {
            return 0;
        }
    }
}
