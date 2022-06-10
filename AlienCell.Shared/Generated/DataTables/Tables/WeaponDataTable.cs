// <auto-generated />
#pragma warning disable CS0105
/* Generated/Data/WeaponData.cs */
using MasterMemory;
using AlienCell.Shared.Data;
using AlienCell.Shared.Structs;
using MasterMemory.Validation;
using MasterMemory;
using System.Collections.Generic;
using System;

namespace AlienCell.Shared.Data.Tables
{
   public sealed partial class WeaponDataTable : TableBase<WeaponData>, ITableUniqueValidate
   {
        public Func<WeaponData, int> PrimaryKeySelector => primaryIndexSelector;
        readonly Func<WeaponData, int> primaryIndexSelector;


        public WeaponDataTable(WeaponData[] sortedData)
            : base(sortedData)
        {
            this.primaryIndexSelector = x => x.Id;
            OnAfterConstruct();
        }

        partial void OnAfterConstruct();


        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public WeaponData FindById(int key)
        {
            var lo = 0;
            var hi = data.Length - 1;
            while (lo <= hi)
            {
                var mid = (int)(((uint)hi + (uint)lo) >> 1);
                var selected = data[mid].Id;
                var found = (selected < key) ? -1 : (selected > key) ? 1 : 0;
                if (found == 0) { return data[mid]; }
                if (found < 0) { lo = mid + 1; }
                else { hi = mid - 1; }
            }
            return default;
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool TryFindById(int key, out WeaponData result)
        {
            var lo = 0;
            var hi = data.Length - 1;
            while (lo <= hi)
            {
                var mid = (int)(((uint)hi + (uint)lo) >> 1);
                var selected = data[mid].Id;
                var found = (selected < key) ? -1 : (selected > key) ? 1 : 0;
                if (found == 0) { result = data[mid]; return true; }
                if (found < 0) { lo = mid + 1; }
                else { hi = mid - 1; }
            }
            result = default;
            return false;
        }

        public WeaponData FindClosestById(int key, bool selectLower = true)
        {
            return FindUniqueClosestCore(data, primaryIndexSelector, System.Collections.Generic.Comparer<int>.Default, key, selectLower);
        }

        public RangeView<WeaponData> FindRangeById(int min, int max, bool ascendant = true)
        {
            return FindUniqueRangeCore(data, primaryIndexSelector, System.Collections.Generic.Comparer<int>.Default, min, max, ascendant);
        }


        void ITableUniqueValidate.ValidateUnique(ValidateResult resultSet)
        {
#if !DISABLE_MASTERMEMORY_VALIDATOR

            ValidateUniqueCore(data, primaryIndexSelector, "Id", resultSet);       

#endif
        }

#if !DISABLE_MASTERMEMORY_METADATABASE

        public static MasterMemory.Meta.MetaTable CreateMetaTable()
        {
            return new MasterMemory.Meta.MetaTable(typeof(WeaponData), typeof(WeaponDataTable), "weapon_data",
                new MasterMemory.Meta.MetaProperty[]
                {
                    new MasterMemory.Meta.MetaProperty(typeof(WeaponData).GetProperty("Id")),
                    new MasterMemory.Meta.MetaProperty(typeof(WeaponData).GetProperty("Name")),
                    new MasterMemory.Meta.MetaProperty(typeof(WeaponData).GetProperty("Description")),
                    new MasterMemory.Meta.MetaProperty(typeof(WeaponData).GetProperty("Ladder")),
                },
                new MasterMemory.Meta.MetaIndex[]{
                    new MasterMemory.Meta.MetaIndex(new System.Reflection.PropertyInfo[] {
                        typeof(WeaponData).GetProperty("Id"),
                    }, true, true, System.Collections.Generic.Comparer<int>.Default),
                });
        }

#endif
    }
}