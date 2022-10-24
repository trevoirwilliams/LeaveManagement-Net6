using LeaveManagement.Web.Data;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
	public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
	{
		public void Configure(EntityTypeBuilder<Employee> builder)
		{
			var hasher= new PasswordHasher<Employee>();
			builder.HasData(
				new Employee
				{
					Id = "f39e6011-1c3e-449d-80c7-6d77d78b9d7d",
					Email = "emreersoylu@hotmail.com",
					NormalizedEmail = "EMREERSOYLU@HOTMAIL.COM",
					NormalizedUserName = "EMREERSOYLU@HOTMAIL.COM",
					UserName = "emreersoylu@hotmail.com",
					FirstName = "Emre",
					LastName = "Ersoylu",
					PasswordHash=hasher.HashPassword(null, "P@ssword1"),
					EmailConfirmed=true
				},
				new Employee
				{
					Id = "f66e1234-1c3e-449d-80c7-6d77d78b9d7d",
					Email = "turkanersoylu@hotmail.com",
					NormalizedEmail = "TURKANERSOYLU@HOTMAIL.COM",
					NormalizedUserName = "TURKANERSOYLU@HOTMAIL.COM",
					UserName = "turkanersoylu@hotmail.com",
					FirstName = "Turkan",
					LastName = "Ersoylu",
					PasswordHash = hasher.HashPassword(null, "P@ssword1"),
					EmailConfirmed = true
				}
				);

		}
	}
}

		