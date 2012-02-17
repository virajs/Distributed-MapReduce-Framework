using System.Collections.Generic;
using System.ServiceModel;
using DMF.Core.Model;

namespace DMF.Core.Contract
{
    /// <summary>
    /// Job Management Service Contract
    /// </summary>
    [ServiceContract(Name = "JobManager")]
    public interface IJobManager
    {
        /// <summary>
        /// Registers the job.
        /// </summary>
        /// <param name="jobName">Name of the job.</param>
        /// <param name="assemblyStream">A compressed array of bytes of the assembly</param>
        [OperationContract]
        void RegisterJob(string jobName, byte[] assemblyStream);

        /// <summary>
        /// Updates the job.
        /// </summary>
        /// <param name="jobName">Name of the job.</param>
        /// <param name="assemblyStream">The assembly stream.</param>
        [OperationContract]
        void UpdateJob(string jobName, byte[] assemblyStream);

        /// <summary>
        /// Removes the job.
        /// </summary>
        /// <param name="jobName">Name of the job.</param>
        [OperationContract]
        void RemoveJob(string jobName);

        /// <summary>
        /// Removes all jobs.
        /// </summary>
        [OperationContract]
        void RemoveAllJobs();

        /// <summary>
        /// Execute map operation.
        /// </summary>
        /// <param name="jobId">The job id.</param>
        /// <param name="jobExecutionId">The job execution id.</param>
        [OperationContract]
        void Map(string jobId, string jobExecutionId);

        /// <summary>
        /// Execute the reduce operation.
        /// </summary>
        /// <param name="jobId">The job id.</param>
        /// <param name="jobExecutionId">The job execution id.</param>
        [OperationContract]
        void Reduce(string jobId, string jobExecutionId);
        
        /// <summary>
        /// Determines whether this slave can afford more jobs.
        /// </summary>
        /// <returns>
        /// 	<c>true</c> if this instance [can slave afford more jobs]; otherwise, <c>false</c>.
        /// </returns>
        [OperationContract]
        bool CanSlaveAffordMoreJobs();
    }
}
