﻿using System.Threading.Tasks;
using WebService.DTOs;
using WebService.Entities;
using WebService.Helpers;

namespace WebService.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);
        Task<AppUser> GetUserWithLikes(int userId);
        Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);
    }
}