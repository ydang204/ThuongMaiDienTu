﻿using OnlineShop.Data.Infrastructure;
using OnlineShop.Model.Models;

namespace OnlineShop.Data.Repositories
{
    public interface IPostTagRepository
    {
    }

    public class PostTagRepository : BaseRepository<PostTag>, IPostTagRepository
    {
        public PostTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}