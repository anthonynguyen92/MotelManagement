using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace MotelManagement.EntityFrameworkCore
{
    public static class MotelManagementDbContextModelCreatingExtensions
    {
        public static void ConfigureMotelManagement(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(MotelManagementConsts.DbTablePrefix + "YourEntities", MotelManagementConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}