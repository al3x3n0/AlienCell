// <auto-generated />
#pragma warning disable CS0105
/* Generated/Data/AchievementData.cs */
using System.Collections.Generic;
/* Generated/Data/AffinityData.cs */
using System.Collections.Generic;
/* Generated/Data/ArtifactData.cs */
using System.Collections.Generic;
/* Generated/Data/ArtifactLadderData.cs */
using System.Collections.Generic;
/* Generated/Data/ArtifactUpgradeMaterialData.cs */
using System.Collections.Generic;
/* Generated/Data/BuildingData.cs */
using System.Collections.Generic;
/* Generated/Data/CurrencyData.cs */
using System.Collections.Generic;
/* Generated/Data/ExpeditionData.cs */
using System.Collections.Generic;
/* Generated/Data/FactionData.cs */
using System.Collections.Generic;
/* Generated/Data/HeroClassData.cs */
using System.Collections.Generic;
/* Generated/Data/HeroData.cs */
using System.Collections.Generic;
/* Generated/Data/HeroLadderData.cs */
using System.Collections.Generic;
/* Generated/Data/HeroSkinData.cs */
using System.Collections.Generic;
/* Generated/Data/HeroUpgradeMaterialData.cs */
using System.Collections.Generic;
/* Generated/Data/HeroWeaponSlotData.cs */
using System.Collections.Generic;
/* Generated/Data/QualityData.cs */
using System.Collections.Generic;
/* Generated/Data/SkillData.cs */
using System.Collections.Generic;
/* Generated/Data/WeaponData.cs */
using System.Collections.Generic;
/* Generated/Data/WeaponLadderData.cs */
using System.Collections.Generic;
/* Generated/Data/WeaponUpgradeMaterialData.cs */
using System.Collections.Generic;
using AlienCell.Shared.Data;
using AlienCell.Shared.Structs;
using MasterMemory.Validation;
using MasterMemory;
using System.Collections.Generic;
using System;
using AlienCell.Shared.Data.Tables;

namespace AlienCell.Shared.Data
{
   public sealed class DatabaseBuilder : DatabaseBuilderBase
   {
        public DatabaseBuilder() : this(null) { }
        public DatabaseBuilder(MessagePack.IFormatterResolver resolver) : base(resolver) { }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<AchievementData> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<AffinityData> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<ArtifactData> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<ArtifactLadderData> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<ArtifactUpgradeMaterialData> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<BuildingData> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<CurrencyData> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<ExpeditionData> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<FactionData> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<HeroClassData> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<HeroData> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<HeroLadderData> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<HeroSkinData> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<HeroUpgradeMaterialData> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<HeroWeaponSlotData> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<QualityData> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<SkillData> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<WeaponData> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<WeaponLadderData> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<WeaponUpgradeMaterialData> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

    }
}