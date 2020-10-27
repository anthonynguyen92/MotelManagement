using MotelManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MotelManagement.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class MotelManagementController : AbpController
    {
        protected MotelManagementController()
        {
            LocalizationResource = typeof(MotelManagementResource);
        }
    }
}