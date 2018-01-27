using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Cheer.Roles.Dto;
using Cheer.Users.Dto;

namespace Cheer.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
