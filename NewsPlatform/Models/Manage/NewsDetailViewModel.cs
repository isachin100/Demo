using NewsPlatform.Application.DTOs;

namespace NewsPlatform.Web.Models.Manage
{
    public class NewsDetailViewModel : BaseViewModel
    {
        public NewsDTO NewsDetail { get; set; } = new NewsDTO();
    }
}
