using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace OtaTicketing.Data
{
    /* This is used if database provider does't define
     * IOtaTicketingDbSchemaMigrator implementation.
     */
    public class NullOtaTicketingDbSchemaMigrator : IOtaTicketingDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}