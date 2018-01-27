using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Cheer.Configuration.Dto;

namespace Cheer.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CheerAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
