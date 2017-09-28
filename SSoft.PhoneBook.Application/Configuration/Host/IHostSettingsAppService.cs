using System.Threading.Tasks;
using Abp.Application.Services;
using SSoft.PhoneBook.Configuration.Host.Dto;

namespace SSoft.PhoneBook.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
