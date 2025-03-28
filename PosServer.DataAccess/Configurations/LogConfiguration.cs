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
    public class LogConfiguration : IEntityTypeConfiguration<LogEntity>
    {
        public void Configure(EntityTypeBuilder<LogEntity> builder)
        {
            builder.Property(x => x.LogDateTime)
                   .HasMaxLength(30)
                   .IsRequired();

            builder.Property(x => x.LogTypeName)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(x => x.LogUsername)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(x => x.LogDirection)
                   .HasMaxLength(11)
                   .IsRequired();

            builder.Property(x => x.LogResult)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(x => x.LogDescription)
                  .IsRequired();

            builder.Property(x => x.LogSession)
                   .HasMaxLength(36)
                   .IsRequired();

            builder.Property(x => x.StatusId)
                   .IsRequired(false);
        }
    }
}
