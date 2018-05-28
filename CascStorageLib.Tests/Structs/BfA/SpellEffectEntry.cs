using CascStorageLib.Attributes;
using System.Runtime.InteropServices;

namespace CascStorageLib.Tests
{
    public class SpellEffectEntry
    {
        [Index]
        public int ID;
        public int DifficultyID;
        public int EffectIndex;
        public uint Effect;
        public float EffectAmplitude;
        public int EffectAttributes;
        public int EffectAura;
        public int EffectAuraPeriod;
        public float EffectBonusCoefficient;
        public float EffectChainAmplitude;
        public int EffectChainTargets;
        public int EffectItemType;
        public int EffectMechanic;
        public float EffectPointsPerResource;
        public float EffectPosFacing;
        public float EffectRealPointsPerLevel;
        public int EffectTriggerSpell;
        public float BonusCoefficientFromAP;
        public float PvpMultiplier;
        public float Coefficient;
        public float Variance;
        public float ResourceCoefficient;
        public float GroupSizeBasePointsCoefficient;
        public float EffectBasePoints;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public int[] EffectMiscValues;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] EffectRadiusIndex;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public uint[] EffectSpellClassMask;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] ImplicitTarget;
        public int SpellID;
    }
}
