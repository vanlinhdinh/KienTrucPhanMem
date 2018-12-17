namespace QuanLyQuanAn.DAL.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyQuanAnModel : DbContext
    {
        public QuanLyQuanAnModel()
            : base("name=QuanLyQuanAn2")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillInfo> BillInfoes { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodCategory> FoodCategories { get; set; }
        public virtual DbSet<TableFood> TableFoods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.userName)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.passWordUser)
                .IsUnicode(false);

            modelBuilder.Entity<Food>()
                .Property(e => e.price)
                .HasPrecision(19, 4);
        }
    }
}
