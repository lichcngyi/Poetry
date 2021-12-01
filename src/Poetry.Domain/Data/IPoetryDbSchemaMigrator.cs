using System.Threading.Tasks;

namespace Poetry.Data
{
    public interface IPoetryDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
