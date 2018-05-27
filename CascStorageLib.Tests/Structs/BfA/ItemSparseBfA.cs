using System.Runtime.InteropServices;

namespace CascStorageLib.Tests.Structs.BfA
{
    public class ItemSparseEntryBfA
    {
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
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public float[] StatPercentageOfSocket;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public int[] StatPercentEditor;
        public int Stackable;
        public int MaxCount;
        public int RequiredAbility;
        public int SellPrice;
        public int BuyPrice;
        public int VendorStackCount;
        public float PriceVariance;
        public float PriceRandomValue;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public uint[] Flags;
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
        public short AllowableClass;
        public byte ExpansionId;
        public byte ArtifactId;
        public byte SpellWeight;
        public byte SpellWeightCategory;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] SocketType;
        public byte SheatheType;
        public byte Material;
        public byte PageMaterialId;
        public byte LanguageId;
        public byte Bonding;
        public byte DamageDamageType;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
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
