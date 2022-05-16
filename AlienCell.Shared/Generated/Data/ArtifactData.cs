/* Generated/Data/ArtifactData.cs */
using MasterMemory;
using MessagePack;

namespace AlienCell.Generated
{

[MemoryTable("artifact_data"), MessagePackObject(true)]  
public class ArtifactData
{
    [PrimaryKey]
    public int Id { get; set; }
    public string Name { get; }
    public string Description { get; }
    public ArtifactLadderData Ladder { get; }
    public ArtifactData (int Id, string Name, string Description, ArtifactLadderData Ladder)
    {
        this.Id = Id;
        this.Name = Name;
        this.Description = Description;
        this.Ladder = Ladder;
    }
}

}
