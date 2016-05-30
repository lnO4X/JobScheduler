using JobScheduler.Core.Job;
using JobScheduler.Data.Entry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobScheduler.Core.Trigger
{
    public class JobBuilder
    {
        private EJS_Job _job;
        private static JobBuilder _builder;

        public static JobBuilder Create<T>()
            where T : IJob
        {
            _builder = new JobBuilder();
            _builder._job = new EJS_Job();
            _builder._job.job_class_name = typeof(T).FullName;
            return _builder;
        }

        public static JobBuilder SetIdentifiyName(string name)
        {
            _builder._job.name = name;
            return _builder;
        }
        public EJS_Job Build()
        {
            return _job;
        }
    }
}
