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
    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.Property(x => x.StatusDescription)
                   .IsRequired();

            builder.HasMany(x => x.Terminals)
                   .WithOne(x => x.Status)
                   .HasForeignKey(x => x.StatusId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
