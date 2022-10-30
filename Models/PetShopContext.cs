using Microsoft.EntityFrameworkCore;

namespace PetShop_EFCoreApiHW4.Models
{
    public class PetShopContext:DbContext
    {
        
        public DbSet<Type_> Types { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Product> Products { get; set; }
        //без використання UserSecrets smarterasp
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SQL8001.site4now.net;Initial Catalog=db_a8dfeb_dbvbu021n;User Id=db_a8dfeb_dbvbu021n_admin;Password=123456Zero");
        }


        ////без використання UserSecrets локально
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=DESKTOP-A858QMV\\SQLEXPRESS; Initial Catalog=PetShopEF; Integrated Security=SSPI;");
        //}



        ////з використанням UserSecrets локально
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //    new ConfigurationBuilder().AddUserSecrets<Pet2ShopContext>()
        //        .Build()
        //        .Providers
        //        .First()
        //        .TryGet("connStr", out var connStr);

        //    optionsBuilder.UseSqlServer(connStr);
        //}
    }
}
