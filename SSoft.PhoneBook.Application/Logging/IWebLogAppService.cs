using Abp.Application.Services;
using SSoft.PhoneBook.Dto;
using SSoft.PhoneBook.Logging.Dto;

namespace SSoft.PhoneBook.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
