using System.Collections.Generic;
using Abp.Dependency;
using Abp.RealTime;

namespace SSoft.PhoneBook.Authorization.Users
{
    public interface IUserLogoutInformer
    {
        void InformClients(IReadOnlyList<IOnlineClient> clients);
    }
}
