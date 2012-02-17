using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DMF.Core.Domain
{
    [DataContract]
    public sealed class JobsContainer
    {
        public string AssemblyFileName { get; set; }

        public string AssemblyName { get; set; }

        public string Version { get; set; }
        
        public byte[] Assembly { get; set; }

        public IList<Job> Jobs { get; set; }
    }
}
