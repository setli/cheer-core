using Abp.Authorization;
using Cheer.Authorization.Roles;
using Cheer.Authorization.Users;

namespace Cheer.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager) : base(userManager)
        {
        }
    }
}
