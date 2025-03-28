using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PosServer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosServer.DataAccess.Configurations
{
    public class EntityConfiguration : IEntityTypeConfiguration<Entity>
    {
        public void Configure(EntityTypeBuilder<Entity> builder)
        {
            builder.Property(x => x.Id)
                   .IsRequired();

            builder.HasKey(x => x.Id);        
        }
    }
}
