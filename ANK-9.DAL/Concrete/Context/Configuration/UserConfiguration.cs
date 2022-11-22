using ANK_9.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ANK_9.DAL.Concrete.Context.Configuration
{
    public class UserConfiguration : BaseConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.UserName)
                   .IsRequired()
                   .HasMaxLength(130);

            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Password)
                .IsRequired();

            builder.Property(x => x.UserTypes)
                .HasConversion(new EnumToStringConverter<UserTypes>())
                .IsRequired();

            builder.HasData(
                new User
                { 
                    ID = 1,
                    UserName = "admin", 
                    Email = "adin@gmail.com",
                    Password = "admin123",
                    UserTypes = UserTypes.Admin,
                    CreateOn = DateTime.Now, 
                    IsActive = true 
                });
        }
    }
}
