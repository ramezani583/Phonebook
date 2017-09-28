using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using SSoft.PhoneBook.Authorization.Users;
using SSoft.PhoneBook.MultiTenancy;

namespace SSoft.PhoneBook.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}
