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
            Storage<WorldSafeLocs> sWorldSafeLocs = new Storage<WorldSafeLocs>(@"D:\Data\dbc\enUS\DBFilesClient\WorldSafeLocs.db2");
            Storage<SoundKitName> sSoundKitNameStorage = new Storage<SoundKitName>(@"D:\Data\dbc\enUS\SoundKitName.db2");
            Storage<AchievementEntry> sAchievementStorage = new Storage<AchievementEntry>(@"D:\Data\dbc\enUS\Achievement.db2");
            Storage<SpellEffectEntry> sSpellEffectStorage = new Storage<SpellEffectEntry>(@"D:\Data\dbc\enUS\SpellEffect.db2");
            Storage<ItemSparseEntryBfA> sBfAItemSparseStorage = new Storage<ItemSparseEntryBfA>(@"D:\Data\dbc\enUS\ItemSparse.db2");
            Storage<SpellEntry> sSpellStorage = new Storage<SpellEntry>(@"D:\Data\dbc\enUS\Spell.db2");
            Storage<MapDifficultyEntry> sMapDifficultyStorage = new Storage<MapDifficultyEntry>(@"D:\Data\dbc\dbfilesclient\MapDifficulty.db2");

            Storage<ItemSparseEntryLegion> sLegionItemSparseStorage = new Storage<ItemSparseEntryLegion>(@"D:\Data\dbc\dbfilesclient\ItemSparse.db2");
        }
    }
}
