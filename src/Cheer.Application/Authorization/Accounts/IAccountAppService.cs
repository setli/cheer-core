using System.Threading.Tasks;
using Abp.Application.Services;
using Cheer.Authorization.Accounts.Dto;

namespace Cheer.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
