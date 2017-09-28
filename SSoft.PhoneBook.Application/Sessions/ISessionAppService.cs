using System.Threading.Tasks;
using Abp.Application.Services;
using SSoft.PhoneBook.Sessions.Dto;

namespace SSoft.PhoneBook.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
