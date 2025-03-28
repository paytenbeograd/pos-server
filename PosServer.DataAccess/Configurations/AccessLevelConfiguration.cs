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
    public class AccessLevelConfiguration : IEntityTypeConfiguration<AccessLevel>
    {
        public void Configure(EntityTypeBuilder<AccessLevel> builder)
        {
            builder.Property(x => x.AccessDescription)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(x => x.StatusId)
                   .IsRequired(false);
        }
    }
}
