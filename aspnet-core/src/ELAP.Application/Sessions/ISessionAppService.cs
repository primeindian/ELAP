using System.Threading.Tasks;
using Abp.Application.Services;
using ELAP.Sessions.Dto;

namespace ELAP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
