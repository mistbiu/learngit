using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s="";
            int x,i,n=0;
            Console.Write("输入一个整数：");
            s = Console.ReadLine();
            x = int.Parse(s);
            Console.WriteLine(x+" 的素数因子有：");
            for (i=2;i<=x/2;i++)
            {
                if(x%i==0)
                {
                    for(int j=2;j<i;j++)
                    {
                        if (i % j == 0)
                            goto outer;
                    }
                    Console.Write(" " + i);
                    n++;
                    if (n < 10) continue;
                    Console.WriteLine();
                    n = 0;
                outer:;
                }
            }
            Console.WriteLine();
        }
    }
}
