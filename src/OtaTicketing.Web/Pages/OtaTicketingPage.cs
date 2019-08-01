using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using OtaTicketing.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace OtaTicketing.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits OtaTicketing.Web.Pages.OtaTicketingPage
     */
    public abstract class OtaTicketingPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<OtaTicketingResource> L { get; set; }
    }
}
