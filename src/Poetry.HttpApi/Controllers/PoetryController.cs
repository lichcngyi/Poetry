using Poetry.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Poetry.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class PoetryController : AbpController
    {
        protected PoetryController()
        {
            LocalizationResource = typeof(PoetryResource);
        }
    }
}