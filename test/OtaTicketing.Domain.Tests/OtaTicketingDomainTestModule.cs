using OtaTicketing.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace OtaTicketing
{
    [DependsOn(
        typeof(OtaTicketingEntityFrameworkCoreTestModule)
        )]
    public class OtaTicketingDomainTestModule : AbpModule
    {

    }
}