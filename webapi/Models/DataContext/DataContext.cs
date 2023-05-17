using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace webapi.Models.DataContext
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Users> Users { get; set; }
        public DbSet<Worker> Masters { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Providers> Providers { get; set; }
        public DbSet<Supplies> Supplies { get; set; }
        public DbSet<Orders> Orders { get; set; }
    }
}
