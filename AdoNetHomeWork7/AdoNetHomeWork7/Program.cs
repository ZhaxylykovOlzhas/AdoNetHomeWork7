using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetHomeWork7
{
	class Program
	{
		static void Main(string[] args)
		{
			ICollection<Meat> meats = null;
			ICollection<Milk> milkProducts = null;
			ICollection<Bakery> bakeryProducts = null;
            using (var context = new SuperMarket())
			{

				var resultMeat = context.Meats.ToList();
				var resultMilk = context.Milks.ToList();
				var resultBakery = context.Bakerys.ToList();

					context.Meats.Add(new Meat
				{
					Type = "Говядина",
					Price = 2000,
					Weight= 1
				});
					context.Milks.Add(new Milk
					{
						Name = "Молоко",
						Price = 250,
                        ShelfLife = "20.01.2019"
					});
					context.Bakerys.Add(new Bakery
					{
						Name = "Хлеб",
						Price = 80,
                        Composition = "Мука и вода"
					});
					context.SaveChanges();
				

				meats = context.Meats.ToList();
				milkProducts = context.Milks.ToList();
				bakeryProducts = context.Bakerys.ToList();
			}

		}
	}
}
