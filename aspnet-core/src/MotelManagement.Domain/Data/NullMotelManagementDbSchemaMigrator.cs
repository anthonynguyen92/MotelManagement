using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MotelManagement.Data
{
    /* This is used if database provider does't define
     * IMotelManagementDbSchemaMigrator implementation.
     */
    public class NullMotelManagementDbSchemaMigrator : IMotelManagementDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}