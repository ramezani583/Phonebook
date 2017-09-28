using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using SSoft.PhoneBook.Authorization.Users;

namespace SSoft.PhoneBook.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}