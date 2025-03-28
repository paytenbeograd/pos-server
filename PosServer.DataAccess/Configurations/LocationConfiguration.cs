using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PosServer.Domain.Entities;

namespace PosServer.DataAccess.Configurations
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.Property(x => x.LocationName)
                   .HasMaxLength(150)   
                   .IsRequired();

            builder.Property(x => x.LocationCode)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(x => x.StatusId)
                   .IsRequired(false);


            builder.HasMany(x => x.Terminals)
                   .WithOne(x => x.Location)
                   .HasForeignKey(x => x.LocationId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
