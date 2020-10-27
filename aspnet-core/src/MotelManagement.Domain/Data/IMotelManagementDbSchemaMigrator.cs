using System.Threading.Tasks;

namespace MotelManagement.Data
{
    public interface IMotelManagementDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
