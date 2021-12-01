using Poetry.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Poetry
{
    [DependsOn(
        typeof(PoetryEntityFrameworkCoreTestModule)
        )]
    public class PoetryDomainTestModule : AbpModule
    {

    }
}