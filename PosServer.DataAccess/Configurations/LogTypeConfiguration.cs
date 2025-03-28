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
    public class LogTypeConfiguration : IEntityTypeConfiguration<LogType>
    {
        public void Configure(EntityTypeBuilder<LogType> builder)
        {
            builder.Property(x => x.LogTypeName)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(x => x.StatusId)
                   .IsRequired(false);
        }
    }
}
