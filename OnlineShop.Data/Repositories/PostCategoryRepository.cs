﻿using OnlineShop.Data.Infrastructure;
using OnlineShop.Model.Models;

namespace OnlineShop.Data.Repositories
{
    public interface IPostCategoryRepository : IRepository<PostCategory>
    {
    }

    public class PostCategoryRepository : BaseRepository<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}