using DMF.Core.Domain;
using DMF.Core.Interfaces;
using MongoDB.Driver;

namespace DMF.Core.Framework
{
    public sealed class OutputService : IOutputService
    {
        private readonly MongoCollection<OutputStore> _outputStoreCollection;

        public OutputService(MongoCollection<OutputStore> outputStoreCollection)
        {
            _outputStoreCollection = outputStoreCollection;
        }

        public void WriteOutput(string jobId, OutputType outputType, dynamic output)
        {
            _outputStoreCollection.Save(new OutputStore()
                                            {
                                                JobId = jobId,
                                                OutputType = outputType,
                                                Output = output
                                            });
        }
    }
}
