using Volo.Abp.Modularity;

namespace Poetry
{
    [DependsOn(
        typeof(PoetryApplicationModule),
        typeof(PoetryDomainTestModule)
        )]
    public class PoetryApplicationTestModule : AbpModule
    {

    }
}