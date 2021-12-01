using Poetry.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Poetry.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class PoetryPageModel : AbpPageModel
    {
        protected PoetryPageModel()
        {
            LocalizationResourceType = typeof(PoetryResource);
        }
    }
}