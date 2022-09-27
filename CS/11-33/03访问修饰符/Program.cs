using System;

namespace _03访问修饰符
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            
        }
    }
    class Person
    {
        private string _name;
        public int _age;
        protected char _gender;
        internal int _chinese;
        protected internal int _math;
    }
    class Student:Person
    {
        public void Test()
        {

        }
    }
}
