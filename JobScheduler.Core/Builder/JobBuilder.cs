using JobScheduler.Core.Job;
using JobScheduler.Data.Entry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobScheduler.Core.Builder
{
    public class JobBuilder
    {
        private JobDetail _job;
        private static JobBuilder _builder;

        public static JobBuilder Create<T>()
            where T : IJob
        {
            _builder = new JobBuilder();
            _builder._job = new JobDetail();
            _builder._job.id = Guid.NewGuid().ToString();
            _builder._job.job_class_name = typeof(T).FullName;
            return _builder;
        }

        public JobBuilder SetIdentifiyName(string name)
        {
            _builder._job.name = name;
            return _builder;
        }
        public IJobDetail Build()
        {
            return _job;
        }
    }
}
