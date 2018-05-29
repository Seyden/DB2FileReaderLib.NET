using CascStorageLib.Attributes;

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
        public int[] EffectMiscValues;
        public uint[] EffectRadiusIndex;
        public uint[] EffectSpellClassMask;
        public uint[] ImplicitTarget;
        public int SpellID;
    }
}
