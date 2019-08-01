using System;
using System.Collections.Generic;
using System.Text;
using OtaTicketing.Localization;
using Volo.Abp.Application.Services;

namespace OtaTicketing
{
    /* Inherit your application services from this class.
     */
    public abstract class OtaTicketingAppService : ApplicationService
    {
        protected OtaTicketingAppService()
        {
            LocalizationResource = typeof(OtaTicketingResource);
        }
    }
}
