using System.Reflection;
using Abp.Modules;

namespace OJava
{
    public class OJavaCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
