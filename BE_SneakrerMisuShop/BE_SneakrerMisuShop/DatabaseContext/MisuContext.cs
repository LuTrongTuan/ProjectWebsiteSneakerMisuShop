using Microsoft.EntityFrameworkCore;
using BE_SneakrerMisuShop.Enitites;
using BE_SneakrerMisuShop.Entities;
using BE_SneakrerMisuShop.Models;

namespace BE_SneakrerMisuShop.DatabaseContext
{
    public class MisuContext : DbContext
    {
        public MisuContext(DbContextOptions<MisuContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Role>().HasData(
                new Role() {Id = 1, Code = "001", Name = "Admin", Status = 1, CreationTime = DateTime.Now},
                new Role() { Id = 2, Code = "002", Name = "Nhân Viên", Status = 1, CreationTime = DateTime.Now },
                new Role() { Id = 3, Code = "003", Name = "Khách hàng", Status = 1, CreationTime = DateTime.Now });
        }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<DetailSale> DetailSales { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
