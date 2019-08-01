using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace OtaTicketing.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(OtaTicketingHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class OtaTicketingConsoleApiClientModule : AbpModule
    {
        
    }
}
