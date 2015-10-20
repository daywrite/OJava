using Abp.Application.Services;

namespace OJava
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class OJavaAppServiceBase : ApplicationService
    {
        protected OJavaAppServiceBase()
        {
            LocalizationSourceName = OJavaConsts.LocalizationSourceName;
        }
    }
}