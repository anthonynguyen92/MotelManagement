using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace MotelManagement.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(MotelManagementHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class MotelManagementConsoleApiClientModule : AbpModule
    {
        
    }
}
