using Volo.Abp.Settings;

namespace MotelManagement.Settings
{
    public class MotelManagementSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(MotelManagementSettings.MySetting1));
        }
    }
}
