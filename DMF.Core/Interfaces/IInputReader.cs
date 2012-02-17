using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DMF.Core.Interfaces
{
    public interface IInputReader<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
        where TKey : class, ISerializable
        where TValue : class, ISerializable
    {

    }
}
