using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Cheer.Controllers
{
    public abstract class CheerControllerBase: AbpController
    {
        protected CheerControllerBase()
        {
            LocalizationSourceName = CheerConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
