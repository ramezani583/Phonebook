using Abp.Notifications;
using SSoft.PhoneBook.Dto;

namespace SSoft.PhoneBook.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}