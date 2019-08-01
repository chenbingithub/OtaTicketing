using OtaTicketing.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace OtaTicketing.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(OtaTicketingEntityFrameworkCoreDbMigrationsModule),
        typeof(OtaTicketingApplicationContractsModule)
        )]
    public class OtaTicketingDbMigratorModule : AbpModule
    {
        
    }
}
