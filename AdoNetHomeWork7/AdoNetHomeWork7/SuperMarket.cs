namespace AdoNetHomeWork7
{
	using System.Data.Entity;


	public class SuperMarket : DbContext
	{

		public SuperMarket()
			: base("name=SuperMarket")
		{
		}

		public DbSet<Meat> Meats { set; get; }
		public DbSet<Bakery> Bakerys { get; set; }
		public DbSet<Milk> Milks { get; set; }
    }
}