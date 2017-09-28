using Abp.Authorization;
using SSoft.PhoneBook.Authorization.Roles;
using SSoft.PhoneBook.Authorization.Users;
using SSoft.PhoneBook.MultiTenancy;

namespace SSoft.PhoneBook.Authorization
{
    /// <summary>
    /// Implements <see cref="PermissionChecker"/>.
    /// </summary>
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
