using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    public class Order
    {
        public int OrderNumber;
      //  string CommodityName;
        public string Client;
        public int[] Amount=new int[8];
        public Order(int [] amount ,int number,string client)
        {
            OrderNumber = number;
        //    CommodityName=name;
            Client = client;
            for (int i = 0; i < 8; i++)
            {
                Amount[i] = amount[i];
            }
        }
    }
   /* public class OrderDetails
    {
        int OrderNumber;
        int[] Amount;
        public OrderDetails(int [] amount,int number)
        {
            
            Amount = new int[8];
            for(int i=0;i<8;i++ )
            {
                Amount[i] = amount[i];
            }
            OrderNumber = number;
        }
        public void ShowDetails()
        {
            int j = 0;
            foreach(string i in AllCommodities)
            {
                Console.WriteLine(i + " : " + Amount[j]);
                j++;
            }
        }
    }*/

    public class OrderService
    {
        List<Order> orders = new List<Order>();
        int NumberAble = 0;
        CommodityList ls = new CommodityList();
        public void AddOrder()//添加订单
        {
            Order NewOrder ;
            Console.WriteLine("输入客户姓名：");
            string name = Console.ReadLine();
            int number = NumberAble++;
        //    NewOrder = new Order(number, name);
            ls.ShowList();
            Console.WriteLine("顺序输入每件商品所需数量：");
            int [] num=new int[8];
            for(int i=0;i<8;i++)
            {
                Console.Write(ls.AllCommodities[i]+";");
                num[i]= int.Parse(Console.ReadLine());

            }
            NewOrder = new Order(num,number, name);
            orders.Add(NewOrder);
        }

        public void DeleteOrder()//删除订单
        {
            Console.WriteLine("输入想要删除的订单号：");
            int number = int.Parse(Console.ReadLine());
            orders.RemoveAll((Order x) => x.OrderNumber == number);
        }
        public void OrderModify()
        {
            Console.WriteLine("输入修改的订单号：");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("输入想要修改的商品名称");
            string s = Console.ReadLine();
            int po = ls.Position(s);
            Console.WriteLine("输入修改数量：");
            int numChange = int.Parse(Console.ReadLine());
            Order o2 = orders.Find(o => o.OrderNumber == number);
            o2.Amount[po] = numChange;
        }
        public void OrderInquiry()
        {
            Order o1;
            Console.WriteLine("按订单号查询请输入1，按客户姓名查询输入2，按照商品名称查询输入3：");
            switch(int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("输入订单号：");
                    int on = int.Parse(Console.ReadLine());
                    o1 = orders.Find((Order o) => o.OrderNumber == on);
                    Console.WriteLine("订单号：" + o1.OrderNumber );
                    Console.WriteLine("客户姓名：" + o1.Client);
                    for (int i = 0; i < 8; i++)
                    {
                        if (o1.Amount[i] != 0)
                            Console.WriteLine(ls.AllCommodities[i] + " : " + o1.Amount[i]);
                    }
                    break;
                case 2:
                    Console.WriteLine("输入客户姓名：");
                    string s = Console.ReadLine();
                    o1 = orders.Find((Order o) => o.Client == s);
                    Console.WriteLine("订单号：" + o1.OrderNumber );
                    Console.WriteLine("客户姓名：" + o1.Client);
                    for (int i = 0; i < 8; i++)
                    {
                        if (o1.Amount[i] != 0)
                            Console.WriteLine(ls.AllCommodities[i] + " : " + o1.Amount[i]);
                    }
                    break;
                case 3:
                    Console.WriteLine("输入查询的商品名称：");
                    string t = Console.ReadLine();
                    int po = ls.Position(t);
                    List<Order> orders2 = new List<Order>();
                    orders2 = orders.FindAll(o => o.Amount [po]!=0);
                    foreach (Order oe in orders2)
                    {
                        Console.WriteLine("订单号：" + oe.OrderNumber);
                        Console.WriteLine("客户姓名：" + oe.Client);
                        Console.WriteLine(t+"数量：" + oe.Amount [po]);
                        Console.WriteLine();
                    }
                    break;
                default:break;
            }
            
        }
    }
    class CommodityList
    {
        public string[] AllCommodities = { "薯片", "饼干", "牛奶", "酸奶", "话梅", "面包", "果汁", "咖啡" };
        public void ShowList()
        {
            Console.WriteLine("我们的商品有：");
            foreach(string i in AllCommodities )
            {
                Console.WriteLine(i);
            }
        }
        public int Position(string name)
        {
            for (int i= 0;i<8;i++)
            {
                if (AllCommodities[i] == name)
                    return i;
            }
            return -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to OrderManagement!");
            OrderService oneOrder = new OrderService();
            while(true)
            {
                Console.WriteLine("1.增加订单");
                Console.WriteLine("2.删除订单");
                Console.WriteLine("3.修改订单");
                Console.WriteLine("4.查询订单");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        oneOrder.AddOrder();
                        break;
                    case 2:
                        oneOrder.DeleteOrder();
                        break;
                    case 3:
                        oneOrder.OrderModify();
                        break;
                    case 4:
                        oneOrder.OrderInquiry();
                        break;
                    default:
                        Console.WriteLine("错误的输入！");
                        break;

                }
            }
        }
    }
}
