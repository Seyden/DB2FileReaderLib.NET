using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CascStorageLib.Tests
{
    public class MapDifficultyEntry
    {
        public string Message;
        public byte DifficultyID;
        public byte ResetInterval;
        public byte MaxPlayers;
        public byte LockID;
        public byte Flags;
        public byte ItemContext;
        public uint ItemContextPickerID;
        public ushort MapID;
    }
}
