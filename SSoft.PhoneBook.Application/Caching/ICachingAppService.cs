using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SSoft.PhoneBook.Caching.Dto;

namespace SSoft.PhoneBook.Caching
{
    public interface ICachingAppService : IApplicationService
    {
        ListResultDto<CacheDto> GetAllCaches();

        Task ClearCache(EntityDto<string> input);

        Task ClearAllCaches();
    }
}
