using Abp.WebApi.Controllers;

namespace SSoft.PhoneBook.WebApi
{
    public abstract class PhoneBookApiControllerBase : AbpApiController
    {
        protected PhoneBookApiControllerBase()
        {
            LocalizationSourceName = PhoneBookConsts.LocalizationSourceName;
        }
    }
}