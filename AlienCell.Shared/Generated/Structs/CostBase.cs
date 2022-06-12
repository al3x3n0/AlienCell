/* Generated/Structs/CostBase.cs */
using System;
using System.Collections.Generic;
using MessagePack;

using AlienCell.Shared.Data;


namespace AlienCell.Shared.Structs
{

    public abstract class CostBase
    {
        public abstract void Accept(ICostVisitor visitor);
    }
}

