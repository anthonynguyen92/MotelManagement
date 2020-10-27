using MotelManagement.Localization;
using Volo.Abp.Application.Services;

namespace MotelManagement
{
    /* Inherit your application services from this class.
     */
    public abstract class MotelManagementAppService : ApplicationService
    {
        protected MotelManagementAppService()
        {
            LocalizationResource = typeof(MotelManagementResource);
        }
    }
}
