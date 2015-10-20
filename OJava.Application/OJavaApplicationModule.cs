using System.Reflection;
using Abp.Modules;

namespace OJava
{
    [DependsOn(typeof(OJavaCoreModule))]
    public class OJavaApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
