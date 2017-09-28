using SSoft.PhoneBook.Dto;

namespace SSoft.PhoneBook.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}