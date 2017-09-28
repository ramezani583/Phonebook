using System.Threading.Tasks;
using Abp.Application.Services;
using SSoft.PhoneBook.Configuration.Tenants.Dto;

namespace SSoft.PhoneBook.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
