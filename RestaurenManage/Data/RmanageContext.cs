using Microsoft.EntityFrameworkCore;
using RestaurenManage.Model;
using System.Collections.Generic;

namespace RestaurenManage.Data
{
    public class RmanageContext: DbContext
    {
        public RmanageContext(DbContextOptions<RmanageContext> options)
            : base(options)
        {
        }

        public DbSet<TableModel> TableModel { get; set; }
        public DbSet<LoginModel> LoginModel { get; set; }
        public DbSet<FoodModel> FoodModel { get; set; }
        public DbSet<CartModel> CartModel { get; set; }
    
    }
}
