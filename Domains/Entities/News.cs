﻿namespace NewsPlatform.Domains.Entities
{
    public  class News
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
