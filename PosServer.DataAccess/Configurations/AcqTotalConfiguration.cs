using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PosServer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosServer.DataAccess.Configurations
{
    public class AcqTotalConfiguration : IEntityTypeConfiguration<AcqTotal>
    {
        public void Configure(EntityTypeBuilder<AcqTotal> builder)
        {
            builder.Property(x => x.Tid)
                .HasMaxLength(8)
                .IsRequired();

            builder.Property(x => x.TotalsDate)
                   .HasMaxLength(30)
                   .IsRequired(false);

            builder.Property(x => x.Totals)
                   .IsRequired(false);

            builder.Property(x => x.StatusId)
                   .IsRequired(false);
        }
    }
}
