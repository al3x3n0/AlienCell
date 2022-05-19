//
using System;
using MagicOnion;

namespace AlienCell.Shared.Services
{

public partial interface ICheatService
{
    public UnaryResult<Ulid> AddArtifact(Ulid userId, int dataId);
}

}
