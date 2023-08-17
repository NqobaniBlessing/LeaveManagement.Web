using LeaveManagement.Common.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "5ee693b3-e594-4f4-8ab9-e71f8d655d47",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper(),
                },
                new IdentityRole
                {
                    Id = "5ec693b3-e694-8dd4-8ac9-e71f8d635a59",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper(),
                }
                );
        }
    }
}