using Microsoft.EntityFrameworkCore;
using MotelManagement.Entites;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace MotelManagement.EntityFrameworkCore
{
    public static class MotelManagementDbContextModelCreatingExtensions
    {
        public static void ConfigureMotelManagement(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<Customer>(b =>
            {
                b.ToTable("Customer");
                b.ConfigureByConvention();
            });

            builder.Entity<Student>(b =>
            {
                b.ToTable("Student");
                b.ConfigureByConvention();
            });

            builder.Entity<Motel>(b =>
            {
                b.ToTable("Motel");
                b.ConfigureByConvention();
            });
        }
    }
}