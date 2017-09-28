using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SSoft.PhoneBook.Authorization.Permissions.Dto;

namespace SSoft.PhoneBook.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
