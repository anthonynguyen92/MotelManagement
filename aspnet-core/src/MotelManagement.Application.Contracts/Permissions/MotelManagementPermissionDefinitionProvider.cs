using MotelManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MotelManagement.Permissions
{
    public class MotelManagementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(MotelManagementPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(MotelManagementPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MotelManagementResource>(name);
        }
    }
}
