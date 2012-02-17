using System.ServiceModel;
using DMF.Core.Contract;

namespace DMF.Core.Framework.Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public sealed class JobManager : IJobManager
    {
        /// <summary>
        /// Registers the job.
        /// </summary>
        /// <param name="jobName">Name of the job.</param>
        /// <param name="assemblyStream">A compressed array of bytes of the assembly</param>
        public void RegisterJob(string jobName, byte[] assemblyStream)
        {
            
        }

        /// <summary>
        /// Updates the job.
        /// </summary>
        /// <param name="jobName">Name of the job.</param>
        /// <param name="assemblyStream">The assembly stream.</param>
        public void UpdateJob(string jobName, byte[] assemblyStream)
        {
            
        }

        /// <summary>
        /// Removes the job.
        /// </summary>
        /// <param name="jobName">Name of the job.</param>
        public void RemoveJob(string jobName)
        {
            
        }

        /// <summary>
        /// Removes all jobs.
        /// </summary>
        public void RemoveAllJobs()
        {
            
        }

        /// <summary>
        /// Executes the job.
        /// </summary>
        /// <param name="jobId">The job id.</param>
        /// <param name="jobExecutionId">The job execution id.</param>
        public void Map(string jobId, string jobExecutionId)
        {
            
        }

        /// <summary>
        /// Pauses the job execution.
        /// </summary>
        /// <param name="jobId">The job id.</param>
        /// <param name="jobExecutionId">The job execution id.</param>
        public void Reduce(string jobId, string jobExecutionId)
        {
            
        }

        /// <summary>
        /// Stops the job execution.
        /// </summary>
        /// <param name="jobId">The job id.</param>
        /// <param name="jobExecutionId">The job execution id.</param>
        public void StopMap(string jobId, string jobExecutionId)
        {
            
        }

        /// <summary>
        /// Determines whether this slave can afford more jobs.
        /// </summary>
        /// <returns>
        /// 	<c>true</c> if this instance [can slave afford more jobs]; otherwise, <c>false</c>.
        /// </returns>
        public bool CanSlaveAffordMoreJobs()
        {
            return false;
        }
    }
}
