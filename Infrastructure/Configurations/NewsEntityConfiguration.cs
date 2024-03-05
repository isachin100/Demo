using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NewsPlatform.Domains.Entities;

namespace NewsPlatform.Infrastructure.Configurations
{
    public class NewsEntityConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Title)
                   .IsRequired();
        }
    }
}
