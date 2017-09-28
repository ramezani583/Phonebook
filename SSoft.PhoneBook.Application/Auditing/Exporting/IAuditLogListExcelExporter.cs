using System.Collections.Generic;
using SSoft.PhoneBook.Auditing.Dto;
using SSoft.PhoneBook.Dto;

namespace SSoft.PhoneBook.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
