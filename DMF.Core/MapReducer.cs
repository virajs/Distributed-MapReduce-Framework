using System.Collections.Generic;
using System.Runtime.Serialization;
using DMF.Core.Interfaces;

namespace DMF.Core
{
    public abstract class MapReducer<TInputKey, TInputValue, TOutputKey, TOutputValue> : IMapper<TInputKey, TInputValue, TOutputKey, TOutputValue>, IReducer<TOutputKey, TOutputValue>
        where TInputKey : class, ISerializable
        where TInputValue : class, ISerializable
        where TOutputKey : class, ISerializable
        where TOutputValue : class, ISerializable
    {
        public abstract IEnumerable<KeyValuePair<TOutputKey, TOutputValue>> Map(TInputKey inputKey, TInputValue inputValue);

        public abstract IEnumerable<TOutputValue> Reduce(KeyValuePair<TOutputKey, IEnumerable<TOutputValue>> input);
    }
}
