using MasterMemory;

using AlienCell.Shared.Data;


namespace AlienCell.ConsoleApp.Data
{
    public partial class GameDataBuilder
    {
        private readonly DatabaseBuilder _builder;

        public GameDataBuilder(DatabaseBuilder builder)
        {
            _builder = builder;
        }

        public byte[] Build()
        {
            return _builder.Build();
        }
    }
}
