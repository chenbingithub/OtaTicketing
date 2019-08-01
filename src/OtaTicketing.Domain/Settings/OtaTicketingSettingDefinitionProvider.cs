using Volo.Abp.Settings;

namespace OtaTicketing.Settings
{
    public class OtaTicketingSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(OtaTicketingSettings.MySetting1));
        }
    }
}
