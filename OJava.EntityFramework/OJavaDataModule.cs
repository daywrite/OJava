using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using OJava.EntityFramework;

namespace OJava
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(OJavaCoreModule))]
    public class OJavaDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<OJavaDbContext>(null);
        }
    }
}
