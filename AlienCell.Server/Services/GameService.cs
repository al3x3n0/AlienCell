using System;
using System.Collections.Generic;
using AutoMapper;
using MagicOnion;
using MagicOnion.Server;
using Microsoft.AspNetCore.Authorization;

using AlienCell.Shared.Services;
using AlienCell.Shared.Protocol.Models;
using AlienCell.Server.Db;
using AlienCell.Server.Db.Models;
using AlienCell.Server.GameData;
using AlienCell.Server.Repositories;
using AlienCell.Server.Filters;


namespace AlienCell.Server.Services
{

//[Authorize]
[FromTypeFilter(typeof(FlushChangesAttribute))]
[FromTypeFilter(typeof(LoadCurrentUserAttribute))]
public partial class GameService : ServiceBase<IGameService>, IGameService
{
    private readonly IUserRepository _users;
    private readonly GameDataService _gd;
    private readonly IMapper _mapper;
    public IUserRepository Users { get => _users; }

    public GameService(
        IUserRepository users,
        IMapper mapper,
        GameDataService gd)
    {
        this._users = users;
        this._mapper = mapper;
        this._gd = gd;
    }

    public async UnaryResult<UserModelDTO> GetUserAsync(Ulid id)
    {
        var user = await this.Users.GetAsync(id);
        return this._mapper.Map<UserModelDTO>(user);
    }
}

}

