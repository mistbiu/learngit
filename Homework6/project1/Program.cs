using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project1 
{

    public class program
    {
        public static void Main(string[] args)
        {
            Order order1 = new Order("10001", "fafa");
            Order order2 = new Order("10002", "lulu");

            OrderDetails details1 = new OrderDetails("酸奶", 1, 10);
            OrderDetails details2 = new OrderDetails("面包", 3, 8);
            OrderDetails details3 = new OrderDetails("牛奶", 2, 5);

            order1.Items = new List<OrderDetails>();
            order1.Items.Add(details1);
            order1.Items.Add(details2);
            order1.Items.Add(details3);

            order2.Items = new List<OrderDetails>();
            order2.Items.Add(details2);

            OrderService temp = new OrderService();
            temp.Add(order1);
            temp.Add(order2);
            temp.OrderMenu();
        }
    }   
}