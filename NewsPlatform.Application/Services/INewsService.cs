using NewsPlatform.Application.DTOs;

namespace NewsPlatform.Application.Services
{
    public interface INewsService
    {
        Task<IEnumerable<NewsDTO>> GetNewsAsync();
        Task<NewsDTO> GetNewsByTitle(string title);
    }
}
