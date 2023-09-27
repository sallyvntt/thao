using System;
using Lib;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using System.Text.RegularExpressions;
namespace Group3.Db
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options) :base(options)
        {
		}
        public DbSet<Users> User { get; set; }
        public DbSet<BrandMst> BrandMsts { get; set; }
        public DbSet<CatMst> CatMsts { get; set; }
        public DbSet<CertifyMst> CertifyMsts { get; set; }
        public DbSet<DimMst> DimMsts { get; set; }
        public DbSet<DimQltyMst> DimQltyMsts { get; set; }
        public DbSet<GoldKrtMst> GoldKrtMsts { get; set; }
        public DbSet<ProdMst> ProdMsts { get; set; }
        public DbSet<StoneMst> StoneMsts { get; set; }
        public DbSet<StoneQltyMst> StoneQltyMsts { get; set; }
        public DbSet<ItemMst> Items { get; set; }
        public DbSet<DimInfoMst> DimInfos { get; set; }
        public DbSet<JewelTypeMst> JewelTypes { get; set; }
        public DbSet<DimQltySubMst> DimQltySubMsts { get; set; }
        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<Product> products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string str = "server=sally;database=s123;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(str);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemMst>()
              .HasKey(i => i.Style_Code);

            modelBuilder.Entity<ItemMst>()
                .HasOne(i => i.Brand)
                .WithMany()
                .HasForeignKey(i => i.Brand_ID);

            modelBuilder.Entity<ItemMst>()
                .HasOne(i => i.Category)
                .WithMany()
                .HasForeignKey(i => i.Cat_ID);

            modelBuilder.Entity<ItemMst>()
                .HasOne(i => i.Certify)
                .WithMany()
                .HasForeignKey(i => i.Certify_ID);

            modelBuilder.Entity<ItemMst>()
                .HasOne(i => i.Product)
                .WithMany()
                .HasForeignKey(i => i.Prod_ID);

            modelBuilder.Entity<ItemMst>()
                .HasOne(i => i.GoldCarat)
                .WithMany()
                .HasForeignKey(i => i.GoldType_ID);
            modelBuilder.Entity<DimMst>()
                .HasOne(d => d.Item)
                .WithMany(i => i.Dimensions)
                .HasForeignKey(d => d.Style_Code);


            modelBuilder.Entity<DimInfoMst>()
                .HasKey(d => d.DimID);


            modelBuilder.Entity<Product>()
                .HasOne(a => a.Category)
                .WithMany(a => a.Products)
                .HasForeignKey(a => a.Cat_ID);
            modelBuilder.Entity<CatMst>()
               .HasMany(c => c.Products) // Giả sử CatMst có một ICollection<Product> được đặt tên là Products
               .WithOne(p => p.Category)
               .HasForeignKey(p => p.Cat_ID);
            modelBuilder.Entity<BrandMst>()
              .HasMany(c => c.products) 
              .WithOne(p => p.brandMst)
              .HasForeignKey(p => p.Brand_ID);


            modelBuilder.Entity<Users>().HasData(
                new Users { Id = 1, Username = "admin", Password = "123", Email = "superadmin@gmail.com", Role = true, Address = "", PhoneNumber = "" },
                new Users { Id = 2, Username = "test", Password = "123", Email = "supertest@gmail.com", Role = false, Address = "", PhoneNumber = "" });
            // Thêm các quan hệ và cấu hình khóa ngoại khác tại đây
            //thêm product
           
            base.OnModelCreating(modelBuilder);
        }
    }
}

