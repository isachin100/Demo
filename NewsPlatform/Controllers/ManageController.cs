using Microsoft.AspNetCore.Mvc;
using NewsPlatform.Application.Services;
using NewsPlatform.Models;
using NewsPlatform.Web.Models;
using NewsPlatform.Web.Models.Manage;
using System.Diagnostics;

namespace NewsPlatform.Web.Controllers
{
    public class ManageController : BaseController
    {
        private readonly INewsService _newsService;


        public ManageController(INewsService newsService)
        {
            _newsService = newsService;
        }

        public async Task<IActionResult> News()
        {
            var news = await _newsService.GetNewsAsync();
            var breadcrumbs = InitializeBreadcrumbsList();
            breadcrumbs.Add(new(nameof(News)));

            var model = new NewsViewModel()
            {
                NewsList = news,
                Heading = nameof(News),
                Breadcrumbs = breadcrumbs
            };

            return View(model);
        }

        [Route("News/Details/{title}")]
        public async Task<IActionResult> Detail(string title)
        {
            var news = await _newsService.GetNewsByTitle(title);
            if(news != null)
            {
                var breadcrumbs = InitializeBreadcrumbsList();
                breadcrumbs.Add(new(nameof(Detail)));
                var model = new NewsDetailViewModel()
                {
                    NewsDetail = news,
                    Heading = nameof(News),
                    Breadcrumbs = breadcrumbs
                };
                return View(model);
            }
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
