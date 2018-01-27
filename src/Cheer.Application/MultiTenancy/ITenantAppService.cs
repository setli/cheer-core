using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Cheer.MultiTenancy.Dto;

namespace Cheer.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
