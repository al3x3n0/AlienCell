/* Generated/Structs/CostBuilding.cs */
using System;
using System.Collections.Generic;
using MessagePack;

using AlienCell.Shared.Data;


namespace AlienCell.Shared.Structs
{

    [MessagePackObject(true)]
    public class CostBuilding : CostBase
    {
        public List<string> Conditions { get; set; }
        
        public override void Accept(ICostVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

