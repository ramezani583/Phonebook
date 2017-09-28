using Abp.Application.Services;
using SSoft.PhoneBook.Tenants.Dashboard.Dto;

namespace SSoft.PhoneBook.Tenants.Dashboard
{
    public interface ITenantDashboardAppService : IApplicationService
    {
        GetMemberActivityOutput GetMemberActivity();
    }
}
