using Abp.Dependency;
using Abp.Runtime.Session;
using Abp.Web.Mvc.Views;

namespace SSoft.PhoneBook.Web.Views
{
    public abstract class PhoneBookWebViewPageBase : PhoneBookWebViewPageBase<dynamic>
    {
       
    }

    public abstract class PhoneBookWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        public IAbpSession AbpSession { get; private set; }
        
        protected PhoneBookWebViewPageBase()
        {
            AbpSession = IocManager.Instance.Resolve<IAbpSession>();
            LocalizationSourceName = PhoneBookConsts.LocalizationSourceName;
        }
    }
}