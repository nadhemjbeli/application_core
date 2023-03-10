using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AN.Infrastructure.Config
{
	public class FlightConfig : IEntityTypeConfiguration<Flight>
	{
		void IEntityTypeConfiguration<Flight>.Configure(EntityTypeBuilder<Flight> builder)
		{
			builder.ToTable("MyFlight");
			builder.HasKey(f => f.FlightId);
			builder.HasMany(f => f.passangers).WithMany(f => f.flights).UsingEntity(p=>p.ToTable("table_flight_passenger"));
			builder.HasOne(f => f.plane).WithMany(f => f.flights).HasPrincipalKey(f => f.PlaneId)
				.OnDelete(DeleteBehavior.SetNull);
		}
	}
}
