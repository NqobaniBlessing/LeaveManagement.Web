using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();

            builder.HasData(
                new Employee
                {
                    Id = "5ab992b3-e594-4cd4-8ca9-e61f8d655d47",
                    Email = "bnyoni@imgsol.co.zw",
                    NormalizedEmail = "BNYONI@IMGSOL.CO.ZW",
                    NormalizedUserName = "BNYONI@IMGSOL.CO.ZW",
                    UserName = "bnyoni@imgsol.co.zw",
                    FirstName = "Blessing",
                    LastName = "Nyoni",
                    PasswordHash = hasher.HashPassword(null, "Password01"),
                    EmailConfirmed = true
                }
              );
        }
    }
}