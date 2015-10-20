using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace OJava
{
    [DependsOn(typeof(AbpWebApiModule), typeof(OJavaApplicationModule))]
    public class OJavaWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(OJavaApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
