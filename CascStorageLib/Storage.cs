using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace CascStorageLib
{
    public class Storage<T> : Dictionary<int, T> where T : class, new()
    {
        public Storage(string fileName)
        {
            DB2Reader reader;

            var stream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            using (var bin = new BinaryReader(stream))
            {
                var identifier = new string(bin.ReadChars(4));
                stream.Position = 0;
                switch (identifier)
                {
                    case "WDC2":
                        reader = new WDC2Reader(stream);
                        break;
                    case "WDC1":
                        reader = new WDC1Reader(stream);
                        break;
                    default:
                        throw new Exception("DBC type " + identifier + " is not supported!");
                }
            }

            FieldInfo[] fields = typeof(T).GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.NonPublic | BindingFlags.Instance).ToArray();
            FieldCache<T>[] fieldCache = new FieldCache<T>[fields.Length];

            for (int i = 0; i < fields.Length; ++i)
                fieldCache[i] = new FieldCache<T>(fields[i], fields[i].GetCustomAttribute<MarshalAsAttribute>()?.SizeConst ?? -1, fields[i].GetSetter<T>());

            IEnumerator<KeyValuePair<int, IDB2Row>> coll = reader.GetEnumerator();
            while (coll.MoveNext())
            {
                KeyValuePair<int, IDB2Row> item = coll.Current;
                T entry = new T();

                item.Value.GetFields(fieldCache, entry);

                Add(item.Key, entry);
            }
        }
    }
}
