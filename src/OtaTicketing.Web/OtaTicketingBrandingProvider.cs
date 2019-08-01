using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace OtaTicketing.Web
{
    [Dependency(ReplaceServices = true)]
    public class OtaTicketingBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "OtaTicketing";
    }
}
