using OtaTicketing.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace OtaTicketing.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class OtaTicketingPageModel : AbpPageModel
    {
        protected OtaTicketingPageModel()
        {
            LocalizationResourceType = typeof(OtaTicketingResource);
        }
    }
}