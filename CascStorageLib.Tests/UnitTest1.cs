using CascStorageLib.Tests.Structs.BfA;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CascStorageLib.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Storage<AchievementEntry> sAchievementStorage = new Storage<AchievementEntry>(@"D:\Data\dbc\enUS\Achievement.db2");
            Storage<ItemSparseEntryBfA> sBfAItemSparseStorage = new Storage<ItemSparseEntryBfA>(@"D:\Data\dbc\enUS\ItemSparse.db2");
            Storage<ItemSparseEntryLegion> sLegionItemSparseStorage = new Storage<ItemSparseEntryLegion>(@"D:\Data\dbc\dbfilesclient\ItemSparse.db2");
            Storage<SpellEntry> sSpellStorage = new Storage<SpellEntry>(@"D:\Data\dbc\enUS\Spell.db2");
            Storage<SpellEffectEntry> sSpellEffectStorage = new Storage<SpellEffectEntry>(@"D:\Data\dbc\dbfilesclient\SpellEffect.db2");
            Storage<MapDifficultyEntry> sMapDifficultyStorage = new Storage<MapDifficultyEntry>(@"D:\Data\dbc\dbfilesclient\MapDifficulty.db2");
        }
    }
}
