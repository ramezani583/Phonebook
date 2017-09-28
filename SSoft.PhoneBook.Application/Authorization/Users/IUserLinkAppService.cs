using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SSoft.PhoneBook.Authorization.Users.Dto;

namespace SSoft.PhoneBook.Authorization.Users
{
    public interface IUserLinkAppService : IApplicationService
    {
        Task LinkToUser(LinkToUserInput linkToUserInput);

        Task<PagedResultDto<LinkedUserDto>> GetLinkedUsers(GetLinkedUsersInput input);

        Task<ListResultDto<LinkedUserDto>> GetRecentlyUsedLinkedUsers();

        Task UnlinkUser(UnlinkUserInput input);
    }
}
