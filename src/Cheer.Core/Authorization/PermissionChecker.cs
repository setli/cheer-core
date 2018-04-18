using Abp.Authorization;
using Cheer.Authorization.Roles;
using Cheer.Authorization.Users;

namespace Cheer.Authorization
{
    /// <summary>
    /// 权限管理者
    /// </summary>
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager) : base(userManager)
        {
        }
    }
}
