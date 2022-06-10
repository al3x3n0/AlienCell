using System;
using System.IO;
using Microsoft.Extensions.Options;

using AlienCell.Shared.Data;


namespace AlienCell.Server.GameData
{
    public partial class GameDataService
    {
        private readonly MemoryDatabase _db;
        public MemoryDatabase Db { get => this._db; }    

        public GameDataService(IOptions<GameDataServiceOptions> opts)
        {
            var dataBytes = File.ReadAllBytes(opts.Value.Path);
            this._db = new MemoryDatabase(dataBytes);
        }
    }
}
