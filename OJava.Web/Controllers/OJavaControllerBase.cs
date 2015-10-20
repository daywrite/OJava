using Abp.Web.Mvc.Controllers;

namespace OJava.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class OJavaControllerBase : AbpController
    {
        protected OJavaControllerBase()
        {
            LocalizationSourceName = OJavaConsts.LocalizationSourceName;
        }
    }
}