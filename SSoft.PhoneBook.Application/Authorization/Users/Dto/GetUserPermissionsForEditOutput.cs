using System.Collections.Generic;
using Abp.Application.Services.Dto;
using SSoft.PhoneBook.Authorization.Permissions.Dto;

namespace SSoft.PhoneBook.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}