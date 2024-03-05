using NewsPlatform.Domains.Entities;
using WillsPlatform.Application.Repositories;

namespace NewsPlatform.Application.Repositories
{
    public interface INewsRepository : IRepository<News>
    {
        Task<IEnumerable<News>> GetAllNewsAsync();
    }
}
