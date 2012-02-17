using System.Runtime.Serialization;

namespace DMF.Core
{
    public interface IMapper<in TKey, in TValue>
        where TKey : class, ISerializable
        where TValue : class, ISerializable
    {
        void Map(TKey key, TValue value);
    }
}
