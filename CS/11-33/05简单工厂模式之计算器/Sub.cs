using System;
using System.Collections.Generic;
using System.Text;

namespace 简单工厂模式之计算器
{
    public class Sub : Operation
    {
        public Sub(int n1, int n2) : base(n1, n2) { }
        public override int GetResult()
        {
            return this.NumberOne - this.NumberTwo;
        }
    }
}
