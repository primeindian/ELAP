using System.Threading.Tasks;
using Abp.Application.Services;
using ELAP.Authorization.Accounts.Dto;

namespace ELAP.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
