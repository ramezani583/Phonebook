using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace SSoft.PhoneBook.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
