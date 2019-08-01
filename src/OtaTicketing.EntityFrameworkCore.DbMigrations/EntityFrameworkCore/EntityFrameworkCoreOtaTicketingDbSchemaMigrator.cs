using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OtaTicketing.Data;
using Volo.Abp.DependencyInjection;

namespace OtaTicketing.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreOtaTicketingDbSchemaMigrator 
        : IOtaTicketingDbSchemaMigrator, ITransientDependency
    {
        private readonly OtaTicketingMigrationsDbContext _dbContext;

        public EntityFrameworkCoreOtaTicketingDbSchemaMigrator(OtaTicketingMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}