using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DMF.Core
{
    public interface IReducer<TKey, TValue>
        where TKey : class, ISerializable
        where TValue : class, ISerializable
    {
        void Reduce(KeyValuePair<TKey, IEnumerable<TValue>> input);
    }
}
