using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
			builder.HasData(
				new IdentityUserRole<string>
				{
					RoleId= "cac43a6e-d8bb-4448-baaf-1add431ccbbf",
					UserId= "f39e6011-1c3e-449d-80c7-6d77d78b9d7d",
				},
				new IdentityUserRole<string>
				{
					RoleId = "cac51a7e-f7bb-4448-baaf-1acd431ddbbf",
					UserId = "f66e1234-1c3e-449d-80c7-6d77d78b9d7d",
				}
				);
		}
    }
}