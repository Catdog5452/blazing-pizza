using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Data;

public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DbContextOptions options)
        : base(options)
    {
        //something
    }

    public DbSet<PizzaSpecial> Specials { get; set; }
}
