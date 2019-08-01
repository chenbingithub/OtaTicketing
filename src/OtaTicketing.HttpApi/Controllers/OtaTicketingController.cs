using OtaTicketing.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace OtaTicketing.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class OtaTicketingController : AbpController
    {
        protected OtaTicketingController()
        {
            LocalizationResource = typeof(OtaTicketingResource);
        }
    }
}