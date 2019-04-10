using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project1 
{

    public class Program
    {
        public static void Main(string[] args)
        {
            menu temp2 = new menu();
            //OrderService temp = new OrderService();
            
            //Order order1 = new Order("10001", "fafa");
            //Order order2 = new Order("10002", "lulu");

            //OrderDetails details1 = new OrderDetails("酸奶", 1, 10);
            //OrderDetails details2 = new OrderDetails("面包", 3, 8);
            //OrderDetails details3 = new OrderDetails("牛奶", 2, 5);

            //order1.Items = new List<OrderDetails>
            //{
            //    details1,
            //    details2,
            //    details3
            //};

            //List<OrderDetails> list = new List<OrderDetails>();
            //order2.Items = list;
            //order2.Items.Add(details2);


            //temp.Add(order1);
            //temp.Add(order2);
            temp2.OrderMenu();
        }
    }   
}