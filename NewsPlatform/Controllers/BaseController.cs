using Microsoft.AspNetCore.Mvc;
using NewsPlatform.Web.Models;

namespace NewsPlatform.Web.Controllers
{
    public class BaseController : Controller
    {
        protected List<Breadcrumb> InitializeBreadcrumbsList()
        {
            var breadcrumbs = new List<Breadcrumb>()
            {
                new("Home", "Home", "Index")
            };

            return breadcrumbs;
        }

        protected string GetCurrentControllerName()
        {
            return ControllerContext.RouteData.Values["controller"]?.ToString();
        }
    }
}
