using CascStorageLib.Attributes;

namespace CascStorageLib.Tests
{
    public class SpellEntry
    {
        [Index]
        public int ID;
        public string NameSubtext;
        public string Description;
        public string AuraDescription;
    }
}
