using Microsoft.EntityFrameworkCore;
using violet.mask.Domain.Catalog;

namespace violet.mask.Data;

public class StoreContext : DbContext
{
    public StoreContext(DbContextOptions<StoreContext> options) : base(options)
    {

    }

    public DbSet<Item> Items { get; set; }
}