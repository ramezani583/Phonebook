using System.Collections.Generic;
using Abp.Application.Services.Dto;
using SSoft.PhoneBook.Editions.Dto;

namespace SSoft.PhoneBook.MultiTenancy.Dto
{
    public class GetTenantFeaturesForEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}