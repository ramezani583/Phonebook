using Abp.Domain.Services;

namespace SSoft.PhoneBook
{
    public abstract class PhoneBookDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected PhoneBookDomainServiceBase()
        {
            LocalizationSourceName = PhoneBookConsts.LocalizationSourceName;
        }
    }
}
