using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsWthConstraints.Utilities
{
    //where T: struct
    //Ensure generic type is a non-nullable value type like int, float, double, or a custom struct
    internal class Struct_Utility<TStruct> where TStruct : struct
    {
        //Let's make a value nullable
        private object _value;
        public Struct_Utility() { }
        public Struct_Utility(TStruct value)
        {
            _value = value;
        }
        public bool HasValue
        {
            get { return _value != null; }
        }
        public TStruct GetValueOrDefault()
        {
            if (HasValue)
            {
                return (TStruct) _value;
            }
            return default(TStruct);
        }
    }
}
