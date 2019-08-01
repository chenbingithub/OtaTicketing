using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace OtaTicketing.EntityFrameworkCore
{
    [DependsOn(
        typeof(OtaTicketingEntityFrameworkCoreModule)
        )]
    public class OtaTicketingEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<OtaTicketingMigrationsDbContext>();
        }
    }
}
