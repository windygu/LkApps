﻿

using Microsoft.Practices.Unity;
namespace Apps.Core
{
	public partial class DependencyRegisterType
	{
		public static void Container(UnityContainer container)
		{
 //------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

			container.RegisterType<Apps.IService.Spl.ISpl_PersonService, Apps.Service.Spl.Spl_PersonService>();
			container.RegisterType<Apps.IRepository.Spl.ISpl_PersonRepository, Apps.Repository.Spl.Spl_PersonRepository>();
			container.RegisterType<Apps.IService.Spl.ISpl_ProductService, Apps.Service.Spl.Spl_ProductService>();
			container.RegisterType<Apps.IRepository.Spl.ISpl_ProductRepository, Apps.Repository.Spl.Spl_ProductRepository>();
			container.RegisterType<Apps.IService.Spl.ISpl_ProductCategoryService, Apps.Service.Spl.Spl_ProductCategoryService>();
			container.RegisterType<Apps.IRepository.Spl.ISpl_ProductCategoryRepository, Apps.Repository.Spl.Spl_ProductCategoryRepository>();
			container.RegisterType<Apps.IService.Spm.ISpm_ExpressInfoService, Apps.Service.Spm.Spm_ExpressInfoService>();
			container.RegisterType<Apps.IRepository.Spm.ISpm_ExpressInfoRepository, Apps.Repository.Spm.Spm_ExpressInfoRepository>();
			container.RegisterType<Apps.IService.Spm.ISpm_LastTimeService, Apps.Service.Spm.Spm_LastTimeService>();
			container.RegisterType<Apps.IRepository.Spm.ISpm_LastTimeRepository, Apps.Repository.Spm.Spm_LastTimeRepository>();
			container.RegisterType<Apps.IService.Spm.ISpm_TracesInfoService, Apps.Service.Spm.Spm_TracesInfoService>();
			container.RegisterType<Apps.IRepository.Spm.ISpm_TracesInfoRepository, Apps.Repository.Spm.Spm_TracesInfoRepository>();
			container.RegisterType<Apps.IService.Sys.ISysAreasService, Apps.Service.Sys.SysAreasService>();
			container.RegisterType<Apps.IRepository.Sys.ISysAreasRepository, Apps.Repository.Sys.SysAreasRepository>();
			container.RegisterType<Apps.IService.Sys.ISysExceptionService, Apps.Service.Sys.SysExceptionService>();
			container.RegisterType<Apps.IRepository.Sys.ISysExceptionRepository, Apps.Repository.Sys.SysExceptionRepository>();
			container.RegisterType<Apps.IService.Sys.ISysLogService, Apps.Service.Sys.SysLogService>();
			container.RegisterType<Apps.IRepository.Sys.ISysLogRepository, Apps.Repository.Sys.SysLogRepository>();
			container.RegisterType<Apps.IService.Sys.ISysLog4NetService, Apps.Service.Sys.SysLog4NetService>();
			container.RegisterType<Apps.IRepository.Sys.ISysLog4NetRepository, Apps.Repository.Sys.SysLog4NetRepository>();
			container.RegisterType<Apps.IService.Sys.ISysModuleService, Apps.Service.Sys.SysModuleService>();
			container.RegisterType<Apps.IRepository.Sys.ISysModuleRepository, Apps.Repository.Sys.SysModuleRepository>();
			container.RegisterType<Apps.IService.Sys.ISysPositionService, Apps.Service.Sys.SysPositionService>();
			container.RegisterType<Apps.IRepository.Sys.ISysPositionRepository, Apps.Repository.Sys.SysPositionRepository>();
			container.RegisterType<Apps.IService.Sys.ISysRightService, Apps.Service.Sys.SysRightService>();
			container.RegisterType<Apps.IRepository.Sys.ISysRightRepository, Apps.Repository.Sys.SysRightRepository>();
			container.RegisterType<Apps.IService.Sys.ISysRoleService, Apps.Service.Sys.SysRoleService>();
			container.RegisterType<Apps.IRepository.Sys.ISysRoleRepository, Apps.Repository.Sys.SysRoleRepository>();
			container.RegisterType<Apps.IService.Sys.ISysSampleService, Apps.Service.Sys.SysSampleService>();
			container.RegisterType<Apps.IRepository.Sys.ISysSampleRepository, Apps.Repository.Sys.SysSampleRepository>();
			container.RegisterType<Apps.IService.Sys.ISysStructService, Apps.Service.Sys.SysStructService>();
			container.RegisterType<Apps.IRepository.Sys.ISysStructRepository, Apps.Repository.Sys.SysStructRepository>();
			container.RegisterType<Apps.IService.Sys.ISysUserService, Apps.Service.Sys.SysUserService>();
			container.RegisterType<Apps.IRepository.Sys.ISysUserRepository, Apps.Repository.Sys.SysUserRepository>();
			container.RegisterType<Apps.IService.Sys.ISysUserConfigService, Apps.Service.Sys.SysUserConfigService>();
			container.RegisterType<Apps.IRepository.Sys.ISysUserConfigRepository, Apps.Repository.Sys.SysUserConfigRepository>();
			container.RegisterType<Apps.IService.Sys.ISysUserMerchantCodeService, Apps.Service.Sys.SysUserMerchantCodeService>();
			container.RegisterType<Apps.IRepository.Sys.ISysUserMerchantCodeRepository, Apps.Repository.Sys.SysUserMerchantCodeRepository>();
		}
	}
}