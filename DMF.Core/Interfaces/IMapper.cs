using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DMF.Core.Interfaces
{
    public interface IMapper<in TInputKey, in TInputValue, TOutputKey, TOutputValue>
        where TInputKey : class, ISerializable
        where TInputValue : class, ISerializable
        where TOutputKey : class, ISerializable
        where TOutputValue : class, ISerializable
    {
        IEnumerable<KeyValuePair<TOutputKey, TOutputValue>> Map(TInputKey inputKey, TInputValue inputValue);
    }
}
