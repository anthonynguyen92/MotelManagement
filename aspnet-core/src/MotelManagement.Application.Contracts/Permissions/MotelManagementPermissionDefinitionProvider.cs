using MotelManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MotelManagement.Permissions
{
    public class MotelManagementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(MotelManagementPermissions.GroupName, L("Permission:Motel"));

            #region student
            var student = myGroup.AddPermission(MotelManagementPermissions.Student.Default, L("Permission:Student"));
            student.AddChild(MotelManagementPermissions.Student.Create, L("Permission:Create"));
            student.AddChild(MotelManagementPermissions.Student.Update, L("Permission:Update"));
            student.AddChild(MotelManagementPermissions.Student.Delete, L("Permission:Delete"));
            #endregion

            #region motel
            var motel = myGroup.AddPermission(MotelManagementPermissions.Motel.Default, L("Permission:motel"));
            motel.AddChild(MotelManagementPermissions.Motel.Create, L("Permission:Create"));
            motel.AddChild(MotelManagementPermissions.Motel.Update, L("Permission:Update"));
            motel.AddChild(MotelManagementPermissions.Motel.Delete, L("Permission:Delete"));
            #endregion

            #region customer
            var customer = myGroup.AddPermission(MotelManagementPermissions.Customer.Default, L("Permission:Customer"));
            customer.AddChild(MotelManagementPermissions.Customer.Create, L("Permission:Create"));
            customer.AddChild(MotelManagementPermissions.Customer.Update, L("Permission:Update"));
            customer.AddChild(MotelManagementPermissions.Customer.Delete, L("Permission:Delete"));
            #endregion
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MotelManagementResource>(name);
        }
    }
}
