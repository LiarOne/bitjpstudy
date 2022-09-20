using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03动物类继承
{
    class Program
    {
        static void Main(string[] args)
        {
            //实现多态：声明父类去指向子类对象
            Animal[] a = { new Cat(),new Dog(),new Pig() };
            for ( int i=0;i<a.Length;i++)
            {
                a[i].Bark();
                a[i].Eat();
                a[i].Drink();
            }
            Console.ReadKey();
        }
    }

    abstract class Animal
    {
        //抽象成员只能存在于抽象类中
        public abstract void Bark(); //父类无法确定子类如何实现时，用抽象abstract
        public void Eat()
        {
            Console.WriteLine("舔着吃");
        }
        public void Drink()
        {
            Console.WriteLine("舔着喝");
        }
    }

    //一个子类继承了一个抽象父类，子类必须重写抽象父类中的所有抽象成员
    class Cat : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("喵喵喵");
        }

        
    }
    class Dog : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("汪汪汪");
        }

    }
    class Pig : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("哼哼哼");
        }

    }
}
