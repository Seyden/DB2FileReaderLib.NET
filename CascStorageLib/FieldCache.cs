using System;
using System.Reflection;

namespace CascStorageLib
{
    public class FieldCache<T>
    {
        public FieldInfo Field;
        public int ArraySize = 0;
        public bool IndexMapField = false;

        public Action<T, object> Setter;

        public FieldCache(FieldInfo field, int arraySize, Action<T, object> setter, bool indexMapField)
        {
            this.Field = field;
            this.ArraySize = arraySize;
            this.Setter = setter;
            this.IndexMapField = indexMapField;
        }
    }
}
