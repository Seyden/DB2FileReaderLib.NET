using CascStorageLib.Attributes;

namespace CascStorageLib.Tests.Structs.BfA
{
    public class ItemSparseEntryBfA
    {
        [Index]
        public int ID;
        public long AllowableRace;
        public string Description;
        public string Name3;
        public string Name2;
        public string Name1;
        public string Name;
        public float DmgVariance;
        public int DurationInInventory;
        public float QualityModifier;
        public int BagFamily;
        public float ItemRange;
        public float[] StatPercentageOfSocket;
        public int[] StatPercentEditor;
        public int Stackable;
        public int MaxCount;
        public int RequiredAbility;
        public int SellPrice;
        public int BuyPrice;
        public int VendorStackCount;
        public float PriceVariance;
        public float PriceRandomValue;
        public uint[] Flags;
        public int Unknown;
        public ushort ItemNameDescriptionId;
        public ushort RequiredTransmogHoliday;
        public ushort RequiredHoliday;
        public ushort LimitCategory;
        public ushort GemProperties;
        public ushort SocketMatchEnchantmentId;
        public ushort TotemCategoryId;
        public ushort InstanceBound;
        public ushort ZoneBound;
        public ushort ItemSet;
        public ushort ItemRandomSuffixGroupId;
        public ushort RandomSelect;
        public ushort LockId;
        public ushort StartQuestId;
        public ushort PageId;
        public ushort ItemDelay;
        public ushort ScalingStatDistributionId;
        public ushort MinFactionId;
        public ushort RequiredSkillRank;
        public ushort RequiredSkill;
        public ushort ItemLevel;
        public ushort AllowableClass;
        public byte ExpansionId;
        public byte ArtifactId;
        public byte SpellWeight;
        public byte SpellWeightCategory;
        public byte[] SocketType;
        public byte SheatheType;
        public byte Material;
        public byte PageMaterialId;
        public byte LanguageId;
        public byte Bonding;
        public byte DamageDamageType;
        public byte[] StatModifierBonusStat;
        public byte ContainerSlots;
        public byte MinReputation;
        public byte RequiredPVPMedal;
        public byte RequiredPVPRank;
        public byte RequiredLevel;
        public byte InventoryType;
        public byte OverallQualityId;
    }
}
