using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SSoft.PhoneBook.Auditing.Dto;
using SSoft.PhoneBook.Dto;

namespace SSoft.PhoneBook.Auditing
{
    public interface IAuditLogAppService : IApplicationService
    {
        Task<PagedResultDto<AuditLogListDto>> GetAuditLogs(GetAuditLogsInput input);

        Task<FileDto> GetAuditLogsToExcel(GetAuditLogsInput input);
    }
}