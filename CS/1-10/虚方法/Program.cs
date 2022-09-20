using System;

namespace 虚方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Daka();
            Manager m = new Manager();
            m.Daka();
            Programmer p = new Programmer();
            p.Daka();

            //Employee e = m;

            Employee[] emps = { emp, m, p };
            for (int i=0; i<emps.Length; i++)
            {
                emps[i].Daka();
            }

            Console.ReadKey();
        }
    }

    class Employee
    {
        public virtual void Daka()
        {
            Console.WriteLine("员工九点打卡");
        }
    }
    class Manager: Employee
    {
        public override void Daka()
        {
            Console.WriteLine("经理11点打卡");
        }
    }
    class Programmer: Employee
    {
        public override void Daka()
        {
            Console.WriteLine("程序员不打卡");
        }
    }
}
