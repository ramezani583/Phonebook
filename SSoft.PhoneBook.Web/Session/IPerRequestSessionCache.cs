using System.Threading.Tasks;
using SSoft.PhoneBook.Sessions.Dto;

namespace SSoft.PhoneBook.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
