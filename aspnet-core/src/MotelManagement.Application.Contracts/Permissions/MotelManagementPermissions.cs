using Volo.Abp.Reflection;

namespace MotelManagement.Permissions
{
    public static class MotelManagementPermissions
    {
        public const string GroupName = "MotelManagement";

        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";
        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(MotelManagementPermissions));
        }

        #region student
        public class Student
        {
            public const string Default = GroupName + ".Student";
            public const string Create = Default + ".Create";
            public const string Update = Default + ".Update";
            public const string Delete = Default + ".Delete";
        }
        #endregion

        #region motel
        public class Motel
        {
            public const string Default = GroupName + ".Motel";
            public const string Create = Default + ".Create";
            public const string Update = Default + ".Update";
            public const string Delete = Default + ".Delete";
        }
        #endregion

        #region customer
        public class Customer
        {
            public const string Default = GroupName + ".Customer";
            public const string Create = Default + ".Create";
            public const string Update = Default + ".Update";
            public const string Delete = Default + ".Delete";
        }
        #endregion
    }
}