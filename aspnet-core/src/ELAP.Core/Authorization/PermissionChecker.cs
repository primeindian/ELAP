using Abp.Authorization;
using ELAP.Authorization.Roles;
using ELAP.Authorization.Users;

namespace ELAP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
