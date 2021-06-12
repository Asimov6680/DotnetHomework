using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework5_1;
using Homework6;
using Microsoft.EntityFrameworkCore;

namespace homework12.Models
{
    public class OrdersContext:DbContext
    {
        public OrdersContext(DbContextOptions<OrdersContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Order> Orders { get; set; }
    }
}
