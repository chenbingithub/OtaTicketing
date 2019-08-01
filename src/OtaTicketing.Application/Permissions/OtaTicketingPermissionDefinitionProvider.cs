using OtaTicketing.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace OtaTicketing.Permissions
{
    public class OtaTicketingPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(OtaTicketingPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(OtaTicketingPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<OtaTicketingResource>(name);
        }
    }
}
