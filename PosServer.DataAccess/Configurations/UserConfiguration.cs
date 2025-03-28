using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PosServer.Domain.Entities;


namespace PosServer.DataAccess.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.UserName)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(x => x.UserPass)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(x => x.UserFirstName)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(x => x.UserLastName)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(x => x.StatusId)
                   .IsRequired();

            builder.Property(x => x.StatusId)
                   .IsRequired(false);

        }
    }
}
