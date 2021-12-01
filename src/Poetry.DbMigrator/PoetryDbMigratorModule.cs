using Poetry.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Poetry.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(PoetryEntityFrameworkCoreModule),
        typeof(PoetryApplicationContractsModule)
        )]
    public class PoetryDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
