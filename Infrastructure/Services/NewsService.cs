using AutoMapper;
using NewsPlatform.Application.Services;
using NewsPlatform.Application.Repositories;
using NewsPlatform.Application.DTOs;

namespace NewsPlatform.Infrastructure.Services
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _newsRepository;
        private readonly IMapper _mapper;

        public NewsService(INewsRepository newsRepository, IMapper mapper)
        {
            _newsRepository = newsRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<NewsDTO>> GetNewsAsync()
        {
            var questions = await _newsRepository.GetAllNewsAsync();
            return _mapper.Map<List<NewsDTO>>(questions);
        }

        public async Task<NewsDTO> GetNewsByTitle(string title)
        {
            var news = await _newsRepository.FindAsync(n => n.Title == title);
            return _mapper.Map<NewsDTO>(news);
        }
    }
}
