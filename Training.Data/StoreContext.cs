using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Training.Data.Models;

namespace Training.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrderProduct> OrderProducts { get; set; }


    }
}
