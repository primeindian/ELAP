using System.Threading.Tasks;
using ELAP.Configuration.Dto;

namespace ELAP.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
