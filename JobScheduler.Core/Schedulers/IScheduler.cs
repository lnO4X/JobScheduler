using JobScheduler.Core.Job;
using JobScheduler.Core.Triggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobScheduler.Core.Schedulers
{
    public interface IScheduler
    {
        void SchedulerJob(IJobDetail job, ITrigger trigger);
    }
}
