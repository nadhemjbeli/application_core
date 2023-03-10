using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AN.Infrastructure.Config
{
	internal class PassengerConfig : IEntityTypeConfiguration<Passanger>
	{
		public void Configure(EntityTypeBuilder<Passanger> builder)
		{
			builder.OwnsOne(f => f.fullName, l =>
			{
				l.Property(f => f.firstName).HasColumnName("firstName").HasMaxLength(20).HasColumnType("varchar");
				l.Property(f => f.lastName).HasColumnName("lastName").HasMaxLength(20).HasColumnType("varchar");
			});
		}
	}
}
