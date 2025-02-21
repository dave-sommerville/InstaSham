using System;
using System.Collections.Generic;
using System.Linq;
using InstaSham.DAL;
using InstaSham.Models;

namespace InstaSham.BLL
{
    public class PostLikeService
    {
        private readonly PostLikeRepository _postLikeRepository;
        public PostLikeService(PostLikeRepository postLikeRepository)
        {
            _postLikeRepository = postLikeRepository;
        }
        public List<PostLike> GetPostLikes()
        {
            return _postLikeRepository.GetAllPostLikes();
        }
        public void AddPostLike(PostLike postLike)
        {

        }
    }
}
