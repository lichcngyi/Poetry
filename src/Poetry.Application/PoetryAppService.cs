using System;
using System.Collections.Generic;
using System.Text;
using Poetry.Localization;
using Volo.Abp.Application.Services;

namespace Poetry
{
    /* Inherit your application services from this class.
     */
    public abstract class PoetryAppService : ApplicationService
    {
        protected PoetryAppService()
        {
            LocalizationResource = typeof(PoetryResource);
        }
    }
}
