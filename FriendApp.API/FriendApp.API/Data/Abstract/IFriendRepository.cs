using FriendApp.API.Helpers;
using FriendApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FriendApp.API.Data.Abstract
{
    public interface IFriendRepository
    {
        void Add<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        Task<bool> SaveAll();

        Task<PagedList<User>> GetUsers(UserParams userParams);

        Task<User> GetUser(int id);

        Task<Photo> GetPhoto(int id);

        Task<Photo> GetMainPhotoForUser(int userId);

        Task<Like> GetLike(int userId, int recipientId);

        Task<Message> GetMessage(int id);

        Task<PagedList<Message>> GetMessagesForUser(MessageParams messageParams);

        Task<IEnumerable<Message>> GetMessageThread(int userId, int recipientId);

    }
}
