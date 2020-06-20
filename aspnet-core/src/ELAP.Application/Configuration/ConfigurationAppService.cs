using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ELAP.Configuration.Dto;

namespace ELAP.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ELAPAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
