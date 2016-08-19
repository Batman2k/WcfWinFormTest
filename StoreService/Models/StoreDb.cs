namespace StoreService.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StoreDb : DbContext
    {
        public StoreDb()
            : base("name=StoreDb")
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.Information)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.Brand)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.PaymentOption)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.DeliveryType)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrdedBy)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Adress)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.County)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.PhoneHome)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.PhoneCell)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.NationalIdentificationNumber)
                .IsUnicode(false);
        }
    }
}
