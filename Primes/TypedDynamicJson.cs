using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class TypedDynamicJson<T> : DynamicObject
    {
        private readonly IDictionary<string, T> _typedProperty;

        public TypedDynamicJson()
        {
            _typedProperty = new Dictionary<string, T>();
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            T typedObj;

            if (_typedProperty.TryGetValue(binder.Name, out typedObj))
            {
                result = typedObj;

                return true;
            }

            result = null;

            return false;
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            if (value.GetType() != typeof(T))
            {
                return false;
            }

            _typedProperty[binder.Name] = (T)value;

            return true;
        }

        public override IEnumerable<string> GetDynamicMemberNames()
        {
            return _typedProperty.Keys;
        }
    }
}
