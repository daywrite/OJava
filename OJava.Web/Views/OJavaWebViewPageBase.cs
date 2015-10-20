using Abp.Web.Mvc.Views;

namespace OJava.Web.Views
{
    public abstract class OJavaWebViewPageBase : OJavaWebViewPageBase<dynamic>
    {

    }

    public abstract class OJavaWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected OJavaWebViewPageBase()
        {
            LocalizationSourceName = OJavaConsts.LocalizationSourceName;
        }
    }
}