﻿using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Authorization.Users;
using SSoft.PhoneBook.Authorization;
using SSoft.PhoneBook.Authorization.Users;
using SSoft.PhoneBook.MultiTenancy;
using Shouldly;
using Xunit;

namespace SSoft.PhoneBook.Tests.Authorization.Users
{
    public class UserAppService_Unlock_Tests : UserAppServiceTestBase
    {
        private readonly UserManager _userManager;
        private readonly LogInManager _loginManager;

        public UserAppService_Unlock_Tests()
        {
            _userManager = Resolve<UserManager>();
            _loginManager = Resolve<LogInManager>();

            CreateTestUsers();
        }

        [Fact]
        public async Task Should_Unlock_User()
        {
            //Arrange

            var user = await GetUserByUserNameAsync("jnash");

            //Pre conditions
            (await _userManager.IsLockedOutAsync(user.Id)).ShouldBeFalse();
            user.IsLockoutEnabled.ShouldBeTrue();

            //Try wrong password until lockout
            AbpLoginResultType loginResultType;
            do
            {
                loginResultType = (await _loginManager.LoginAsync(user.UserName, "wrong-password", Tenant.DefaultTenantName)).Result;
            } while (loginResultType != AbpLoginResultType.LockedOut);

            (await _userManager.IsLockedOutAsync(user.Id)).ShouldBeTrue();

            //Act

            await UserAppService.UnlockUser(new EntityDto<long>(user.Id));

            //Assert

            (await _loginManager.LoginAsync(user.UserName, "wrong-password", Tenant.DefaultTenantName)).Result.ShouldBe(AbpLoginResultType.InvalidPassword);
        }
    }
}