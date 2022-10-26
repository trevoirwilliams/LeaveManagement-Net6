using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "admin12-f7bb-4448-baaf-1add431ccbbf",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper(),
                },
                new IdentityRole
                {
                    Id = "user12-f7bb-4448-baaf-1acd431ddbbf",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }
                );

        }
    }
}