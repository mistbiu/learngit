using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class OrderDB : DbContext
    {
        public OrderDB()
            : base("OrderDataBase")
        {
        }
        public DbSet<Order> tb_Order { get; set; }

        public DbSet<OrderDetails> tb_OrderDetails { get; set; }
    }
}