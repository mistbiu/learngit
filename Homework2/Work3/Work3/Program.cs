using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[98];
            int i, j,n=0;
            for (i = 0; i < 98; i++)
                num[i] = i + 2;
            for(j=2;j<=Math.Sqrt(100);j++)
            {
                for(i=j-1;i<98;i++)
                {
                    if (num[i] % j == 0)
                        num[i] = 0;
                }
            }
            Console.WriteLine("2到100内的素数有：");
            for (i=0;i<98;i++)
            {
                if(num[i]!=0)
                {
                    Console.Write(" " + num[i]);
                    n++;
                }
                if (n < 10) continue;
                n = 0;
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
