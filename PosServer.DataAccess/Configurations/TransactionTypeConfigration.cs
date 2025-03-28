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
    public class TransactionTypeConfigration : IEntityTypeConfiguration<TransactionType>
    {
        public void Configure(EntityTypeBuilder<TransactionType> builder)
        {
            builder.Property(x => x.TransactionTypes)
                   .HasMaxLength(60)
                   .IsRequired(false);

            builder.Property(x => x.UserAccessLevel)
                   .HasMaxLength(20)
                   .IsRequired(false);


        }
    }
}
