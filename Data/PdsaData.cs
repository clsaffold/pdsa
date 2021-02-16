using System;
using Microsoft.EntityFrameworkCore;

namespace PdsaTracker.Data

{
	public class PdsaDbContext: DbContext
	{
		public DbSet<pdsatracker.Models.Pdsa> Pdsas { get; set; }

		public PdsaDbContext(DbContextOptions<PdsaDbContext> options) : base(options)
		//static private Dictionary<int, Pdsa> Entries = new Dictionary<int, pdsa>();
		{
		}
	}
}
