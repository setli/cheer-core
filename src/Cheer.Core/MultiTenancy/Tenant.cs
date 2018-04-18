using Abp.MultiTenancy;
using Cheer.Authorization.Users;

namespace Cheer.MultiTenancy
{
    /// <summary>
    /// 多租户
    /// </summary>
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
