using System.Threading.Tasks;

namespace Xplore.Data;

public interface IXploreDbSchemaMigrator
{
    Task MigrateAsync();
}
