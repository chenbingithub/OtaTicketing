using Volo.Abp.Modularity;

namespace OtaTicketing
{
    [DependsOn(
        typeof(OtaTicketingApplicationModule),
        typeof(OtaTicketingDomainTestModule)
        )]
    public class OtaTicketingApplicationTestModule : AbpModule
    {

    }
}