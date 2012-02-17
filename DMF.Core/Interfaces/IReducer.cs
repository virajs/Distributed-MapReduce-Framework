using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DMF.Core.Interfaces
{
    public interface IReducer<TOutputKey, TOutputValue>
        where TOutputKey : class, ISerializable
        where TOutputValue : class, ISerializable
    {
        IEnumerable<TOutputValue> Reduce(KeyValuePair<TOutputKey, IEnumerable<TOutputValue>> input);
    }
}
