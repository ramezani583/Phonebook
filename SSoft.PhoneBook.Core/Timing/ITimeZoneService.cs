﻿using System.Threading.Tasks;
using Abp.Configuration;

namespace SSoft.PhoneBook.Timing
{
    public interface ITimeZoneService
    {
        Task<string> GetDefaultTimezoneAsync(SettingScopes scope, int? tenantId);
    }
}
