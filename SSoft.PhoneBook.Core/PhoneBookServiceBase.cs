using Abp;

namespace SSoft.PhoneBook
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="PhoneBookDomainServiceBase"/>.
    /// For application services inherit PhoneBookAppServiceBase.
    /// </summary>
    public abstract class PhoneBookServiceBase : AbpServiceBase
    {
        protected PhoneBookServiceBase()
        {
            LocalizationSourceName = PhoneBookConsts.LocalizationSourceName;
        }
    }
}