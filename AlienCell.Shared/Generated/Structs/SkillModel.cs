/* Generated/Structs/SkillModel.cs */
using System;
using MessagePack;

using AlienCell.Shared.Data;


namespace AlienCell.Shared.Structs
{

[MessagePackObject(true)]
public class SkillModel
{
    public int Level { get; set; }
    public SkillData.Types Data { get; set; }
}

}
