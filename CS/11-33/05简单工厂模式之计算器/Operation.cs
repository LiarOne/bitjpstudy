using System;
using System.Collections.Generic;
using System.Text;

namespace 简单工厂模式之计算器
{
    public abstract class Operation
    {
        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }
        public Operation(int n1,int n2)
        {
            this.NumberOne = n1;
            this.NumberTwo = n2;
        }
        public abstract int GetResult();
    }
}
