using System.Threading.Tasks;
using Cheer.Configuration.Dto;

namespace Cheer.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
