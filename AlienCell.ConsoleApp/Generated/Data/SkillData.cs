/* Generated/Data/SkillData.cs */
using MasterMemory;

using AlienCell.Shared.Data;
using AlienCell.Shared.Structs;


namespace AlienCell.ConsoleApp.Data
{

public partial class GameDataBuilder
{
    private void InitSkillData()
    {
        _builder.Append(new SkillData[]
        {
            new SkillData(Id: (int)SkillData.Types.SUPER_SLASH, Name: "Super slash" ),

        });
    }
}

}
