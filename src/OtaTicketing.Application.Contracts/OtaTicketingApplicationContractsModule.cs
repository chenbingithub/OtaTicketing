﻿using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;

namespace OtaTicketing
{
    [DependsOn(
        typeof(OtaTicketingDomainSharedModule),
        typeof(AbpFeatureManagementApplicationContractsModule),
        typeof(AbpIdentityApplicationContractsModule),
        typeof(AbpPermissionManagementApplicationContractsModule),
        typeof(AbpTenantManagementApplicationContractsModule)
    )]
    public class OtaTicketingApplicationContractsModule : AbpModule
    {

    }
}
