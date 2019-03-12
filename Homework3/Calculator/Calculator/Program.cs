/*参考抽象工厂模式，程序实现加减乘除运算。*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class Calculate
    {
        private string myOp;
        public Calculate(string s)
        {
            myOp = s;
        }
        public string Op
        {
            get
            {
                return myOp;
            }
            set
            {
                myOp = value;
            }
        }
        public abstract double Result
        {
            get;
        }
        public override string ToString()
        {
            return Op + " = " + Result.ToString("#0.00");
        }
    }
    public class Add : Calculate
    {
        private int num1, num2;
        public Add(int n1,int n2,string op):base(op)
        {
            num1 = n1;
            num2 = n2;
        }
        public override double Result
        {
            get
            {
                return num1 + num2;
            }
        }
    }
    public class Sub : Calculate
    {
        private int num1, num2;
        public Sub(int n1, int n2, string op) : base(op)
        {
            num1 = n1;
            num2 = n2;
        }
        public override double Result
        {
            get
            {
                return num1 - num2;
            }
        }
    }
    public class Mul : Calculate
    {
        private int num1, num2;
        public Mul(int n1, int n2, string op) : base(op)
        {
            num1 = n1;
            num2 = n2;
        }
        public override double Result
        {
            get
            {
                return num1 * num2;
            }
        }
    }
    public class Div : Calculate
    {
        private int num1, num2;
        public Div(int n1, int n2, string op) : base(op)
        {
            num1 = n1;
            num2 = n2;
        }
        public override double Result
        {
            get
            {
                return (double)num1/(double)num2;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculate[] cals =
            {
                new Add(34,23,"34 add 23 "),
                new Sub(32, 14, "32 sub 14 "),
                new Mul(6, 17, "6 mul 17 "),
                new Div(62, 4, "62 div 4 ")
            };
            Console.WriteLine("Calcutator working");
            foreach(Calculate c in cals)
            {
                Console.WriteLine(c);
            }
        }
    }
}
