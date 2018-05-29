using System;
using System.Reflection;

namespace CascStorageLib
{
    public class FieldCache<T>
    {
        public FieldInfo Field;
        public bool IsArray = false;
        public bool IndexMapField = false;

        public Action<T, object> Setter;

        public FieldCache(FieldInfo field, bool isArray, Action<T, object> setter, bool indexMapField)
        {
            this.Field = field;
            this.IsArray = isArray;
            this.Setter = setter;
            this.IndexMapField = indexMapField;
        }
    }
}
