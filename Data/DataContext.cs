using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(builder =>
            {
                builder.HasOne(x => x.User).WithMany(x => x.Orders);
                builder.HasMany(x => x.Details).WithOne(x => x.Order).HasForeignKey(x => x.OrderId);
            });
        
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}
