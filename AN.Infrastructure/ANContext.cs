using AM.ApplicationCore.Domain;
using AN.Infrastructure.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AN.Infrastructure
{
	public class ANContext: DbContext
	{
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfiguration(new FlightConfig());
			modelBuilder.ApplyConfiguration(new PlaneConfig());
			modelBuilder.ApplyConfiguration(new PassengerConfig());
			modelBuilder.Entity<Flight>().ToTable("MyFlight");
			modelBuilder.Entity<Flight>().HasKey(f => f.FlightId);
			//modelBuilder.Entity<Passanger>().Property(f => f.EmailAddress)
			//	.HasColumnName("PassengerName")
			//	.HasMaxLength(50)
			//	.IsRequired()
			//	.HasColumnType("varchar");
		}
		protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
		{
			configurationBuilder.Properties<string>().HaveColumnType("varchar").HaveMaxLength(50);
			configurationBuilder.Properties<DateTime>().HaveColumnType("date");
			configurationBuilder.Properties<double>().HavePrecision(2, 3);

		}

		public DbSet<Flight> Flights { get; set; }
		public DbSet<Plane> Planes { get; set; }
		public DbSet<Passanger> Passangers { get; set; }
		public DbSet<Traveller> Travellers { get; set; }
		public DbSet<Staff> Staffs { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"data source = (localdb)\mssqllocaldb; initial catalog = nadhemJbeli; integrated security = true;");
		}


	}
}
