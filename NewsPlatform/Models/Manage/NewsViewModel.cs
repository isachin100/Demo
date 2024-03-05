using NewsPlatform.Application.DTOs;

namespace NewsPlatform.Web.Models.Manage
{
    public class NewsViewModel : BaseViewModel
    {
        public IEnumerable<NewsDTO> NewsList { get; set; } = new List<NewsDTO>();
    }
}
