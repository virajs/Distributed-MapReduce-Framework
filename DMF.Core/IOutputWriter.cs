using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DMF.Core
{
    public interface IOutputWriter<in TOutput>
        where TOutput : class, ISerializable
    {
        void Write(IEnumerable<TOutput> value);
    }
}
