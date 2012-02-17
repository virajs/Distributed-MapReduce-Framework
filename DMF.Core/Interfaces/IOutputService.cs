namespace DMF.Core.Interfaces
{
    public interface IOutputService
    {
        void WriteOutput(string jobId, OutputType outputType, dynamic output);
    }
}
