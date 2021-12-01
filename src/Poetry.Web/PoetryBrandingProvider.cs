using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Poetry.Web
{
    [Dependency(ReplaceServices = true)]
    public class PoetryBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Poetry";
    }
}
