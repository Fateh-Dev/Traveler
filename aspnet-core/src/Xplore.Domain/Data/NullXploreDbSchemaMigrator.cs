using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Xplore.Data;

/* This is used if database provider does't define
 * IXploreDbSchemaMigrator implementation.
 */
public class NullXploreDbSchemaMigrator : IXploreDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
