using System.Threading.Tasks;
using Abp.Application.Services;
using Cheer.Sessions.Dto;

namespace Cheer.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
