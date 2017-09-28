using System.Threading.Tasks;
using Abp;
using Abp.Notifications;
using SSoft.PhoneBook.Authorization.Users;
using SSoft.PhoneBook.MultiTenancy;

namespace SSoft.PhoneBook.Notifications
{
    public interface IAppNotifier
    {
        Task WelcomeToTheApplicationAsync(User user);

        Task NewUserRegisteredAsync(User user);

        Task NewTenantRegisteredAsync(Tenant tenant);

        Task SendMessageAsync(UserIdentifier user, string message, NotificationSeverity severity = NotificationSeverity.Info);
    }
}
