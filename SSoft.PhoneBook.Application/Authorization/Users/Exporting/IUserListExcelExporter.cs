using System.Collections.Generic;
using SSoft.PhoneBook.Authorization.Users.Dto;
using SSoft.PhoneBook.Dto;

namespace SSoft.PhoneBook.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}