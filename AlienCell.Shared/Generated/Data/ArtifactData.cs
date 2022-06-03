/* Generated/Data/ArtifactData.cs */
using MasterMemory;

using AlienCell.Shared.Structs;


namespace AlienCell.Shared.Data
{

[MemoryTable("artifact_data"), MessagePack.MessagePackObject(true)]  
public class ArtifactData
{
    public enum Types : int
    {
    }

    [PrimaryKey]
    public int Id { get; }
    public string Name { get; }
    public string Description { get; }
    public ArtifactLadderData.Types Ladder { get; }
    public ArtifactData (int Id, string Name, string Description, ArtifactLadderData.Types Ladder)
    {
        this.Id = Id;
        this.Name = Name;
        this.Description = Description;
        this.Ladder = Ladder;
    }
}

}
