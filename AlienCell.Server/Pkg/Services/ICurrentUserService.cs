using System;

using AlienCell.Server.Db.Models;


namespace AlienCell.Server.Services
{
    public interface ICurrentUserService
    {
        Task<UserModel> LoadAsync(Ulid userId);
        UserModel User { get; }
    }
}