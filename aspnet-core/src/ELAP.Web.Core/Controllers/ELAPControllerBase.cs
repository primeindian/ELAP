using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ELAP.Controllers
{
    public abstract class ELAPControllerBase: AbpController
    {
        protected ELAPControllerBase()
        {
            LocalizationSourceName = ELAPConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
