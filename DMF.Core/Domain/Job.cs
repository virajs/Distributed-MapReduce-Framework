using System.Runtime.Serialization;

namespace DMF.Core.Domain
{
    [DataContract]
    public sealed class Job
    {
        public string Id { get; set; }

        public string FullName { get; set; }

        public string InputReaderType { get; set; }
    }
}