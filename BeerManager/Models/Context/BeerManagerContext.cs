using Microsoft.EntityFrameworkCore;

namespace BeerManager.Models.Context
{
	public class BeerManagerContext: DbContext
	{
		public BeerManagerContext(DbContextOptions options): base(options)
		{
		}

        public DbSet<Brasserie> Brasseries { get; set; }
        public DbSet<Beer> Beers { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Stock> Stocks { get; set; }
    }
}

