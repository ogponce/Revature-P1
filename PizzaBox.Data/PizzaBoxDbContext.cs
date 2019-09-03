using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;

namespace PizzaBox.Data
{
  public class PizzaBoxDbContext: DbContext
  {
    public DbSet<User> Users { get; set; }
    public DbSet<Account> Accounts {get;set;}

    public DbSet<Location> Locations {get;set;}

    public DbSet<Pizza> Pizzas {get;set;}

    public DbSet<Size> Sizes {get;set;}

    public DbSet<Crust> Crusts {get;set;}

    public DbSet<Topping> ToppingsTable {get;set;}
    public DbSet<Order> Orders {get;set;}




    
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("server=tcp:project0-ogp.database.windows.net,1433;initial catalog=PizzaBox1;user id=sequeladmin;password=Candy2017");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<User>().HasKey(u => u.UserId);
      builder.Entity<User>().HasIndex(u => u.Username).IsUnique();
      builder.Entity<Account>().HasKey(a => a.AccountId);
      builder.Entity<Pizza>().HasKey(p => p.PizzaId);
      builder.Entity<Location>().HasKey(l=>l.LocationId);
      builder.Entity<Size>().HasKey(s=>s.SizeId);
      builder.Entity<Crust>().HasKey(c=>c.CrustId);
      builder.Entity<Topping>().HasKey(t=>t.ToppingId);
      builder.Entity<Order>().HasKey(o=>o.OrderId);
    }

  }
}