﻿using InstaSham.Models;

namespace InstaSham.DAL
{
    public class PostLikeRepository
    {
        private readonly InstaShamContext _context;
        public PostLikeRepository(InstaShamContext context)
        {
            _context = context;
        }
        public List<PostLike> GetAllPostLikes()
        {
            return _context.PostLikes.ToList();
        }
        public void AddPostLike(PostLike postLike)
        {
            _context.PostLikes.Add(postLike);
            _context.SaveChanges();
        }
    }
}
