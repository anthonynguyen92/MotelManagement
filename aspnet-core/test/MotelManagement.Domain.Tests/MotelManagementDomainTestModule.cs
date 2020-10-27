using MotelManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MotelManagement
{
    [DependsOn(
        typeof(MotelManagementEntityFrameworkCoreTestModule)
        )]
    public class MotelManagementDomainTestModule : AbpModule
    {

    }
}