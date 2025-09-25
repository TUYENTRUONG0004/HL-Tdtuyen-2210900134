using Microsoft.EntityFrameworkCore;
using NetCoreLAB6.EF.Models;

namespace NetCoreLAB6.EF.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        // Tùy chọn cấu hình bổ sung (nếu cần)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-5491VFA;Database=NetCoreCRUD;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }
    }
}