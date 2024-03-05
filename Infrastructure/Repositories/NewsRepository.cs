using Infrastructure;
using Microsoft.EntityFrameworkCore;
using NewsPlatform.Application.Repositories;
using NewsPlatform.Domains.Entities;
using WillsPlatform.Infrastructure.Repositories;

namespace NewsPlatform.Infrastructure.Repositories
{
    public sealed class NewsRepository : BaseRepository<News>, INewsRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public NewsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<News>> GetAllNewsAsync()
        {
            var query = GetAllQueryable();
            return await query.ToListAsync();
        }
    }
}
