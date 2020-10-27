using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace MotelManagement
{
    [Dependency(ReplaceServices = true)]
    public class MotelManagementBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "MotelManagement";
    }
}
