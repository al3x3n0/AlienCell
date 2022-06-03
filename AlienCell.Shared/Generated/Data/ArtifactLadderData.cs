/* Generated/Data/ArtifactLadderData.cs */
using MasterMemory;

using AlienCell.Shared.Structs;


namespace AlienCell.Shared.Data
{

[MemoryTable("artifact_ladder_data"), MessagePack.MessagePackObject(true)]  
public class ArtifactLadderData
{
    public enum Types : int
    {
        DEFAULT_LADDER = 0,
    }

    [PrimaryKey]
    public int Id { get; }
    public List<ArtifactLevelLadderData> Levels { get; }
    public ArtifactLadderData (int Id, List<ArtifactLevelLadderData> Levels)
    {
        this.Id = Id;
        this.Levels = Levels;
    }
}

}
