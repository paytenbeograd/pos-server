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
    public class TerminalConfiguration : IEntityTypeConfiguration<Terminal>
    {
        public void Configure(EntityTypeBuilder<Terminal> builder)
        {
            builder.Property(x => x.Tid)
                   .HasMaxLength(8)
                   .IsRequired();

            builder.Property(x => x.TerminalName)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(x => x.LocationId)
                   .IsRequired();

            builder.Property(x => x.IpAdress)
                   .HasMaxLength(21)
                   .IsRequired();

            builder.Property(x => x.Settlement)
                   .IsRequired(false);

            builder.Property(x => x.SettlementDate)
                   .HasMaxLength(30)
                   .IsRequired(false);

            builder.Property(x => x.StatusId)
                   .IsRequired(false);
        }
    }
}
