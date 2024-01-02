using Microsoft.EntityFrameworkCore;
using BOL;
namespace DAL;

public class CollectionContex: DbContext
{
    public DbSet<Product> Products{get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString="server=localhost;port=3306;user=root;password=welcome;database=ecommerce";       
        optionsBuilder.UseMySQL(conString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product> (entity =>{
            entity.HasKey(e=> e.Productid);
            entity.Property(e => e.Title).IsRequired();
            entity.Property(e => e.Description).IsRequired();
            entity.Property(e => e.Unitprice).IsRequired();
            entity.Property(e => e.Categoryid).IsRequired();
            entity.Property(e => e.Unitinstock).IsRequired();
        });
        modelBuilder.Entity<Product>().ToTable("Products");
    }
}