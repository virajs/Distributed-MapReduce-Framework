using MongoDB.Bson;

namespace DMF.Core.Domain
{
    public sealed class OutputStore
    {
        public ObjectId Id { get; set; }

        public string JobId { get; set; }

        public OutputType OutputType { get; set; }

        public dynamic Output { get; set; }
    }
}
