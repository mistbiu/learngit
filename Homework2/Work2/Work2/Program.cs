using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入数组元素个数：");
            string s = "";
            int n = 0;
            s = Console.ReadLine();
            n = int.Parse(s);
            int[] nums = new int[n];
            Console.Write("依次输入数组元素值（输入一个值后按回车键进入下一个）：");
            for (int i=0;i<n;i++)
            {
                s = Console.ReadLine();
                nums[i]= int.Parse(s);
            }
            int max = nums[0];
            int min =nums[0];
            double sum = nums[0], averg = 0;
            for(int j=1;j<n;j++)
            {
                if (nums[j] > max)
                    max = nums[j];
                else if (nums[j] < min)
                    min = nums[j];
                sum += nums[j];
            }
            averg = sum / n;
            s = averg.ToString("#0.00");//保留小数点后2位
            Console.WriteLine("最大值为 " + max);
            Console.WriteLine("最小值为 " + min);
            Console.WriteLine("和为 " + sum);
            Console.WriteLine("平均值为 " + s);
        }
    }
}
