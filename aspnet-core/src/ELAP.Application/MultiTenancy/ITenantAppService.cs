using Abp.Application.Services;
using ELAP.MultiTenancy.Dto;

namespace ELAP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

