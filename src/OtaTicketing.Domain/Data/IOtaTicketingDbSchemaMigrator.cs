using System.Threading.Tasks;

namespace OtaTicketing.Data
{
    public interface IOtaTicketingDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
