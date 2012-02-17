using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DMF.Core
{
    public interface IInputReader<TKey, TValue>
        where TKey : class, ISerializable
        where TValue : class, ISerializable
    {
        IEnumerable<KeyValuePair<TKey, TValue>> GetInputEnumerable();
    }
}
