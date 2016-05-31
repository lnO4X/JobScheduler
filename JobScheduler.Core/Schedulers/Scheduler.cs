using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobScheduler.Core.Job;
using JobScheduler.Core.Triggers;
using JobScheduler.Data.Entry;
using JobScheduler.Data;

namespace JobScheduler.Core.Schedulers
{
    internal class Scheduler : EJS_Scheduler, IScheduler
    {
        public void SchedulerJob(IJobDetail job, ITrigger trigger)
        {
            if (job == null || trigger == null)
            {
                throw new ArgumentNullException();
            }

            var ejs_job = job as EJS_Job;
            var ejs_trigger = trigger as EJS_Trigger;
            if (ejs_job != null && ejs_trigger != null)
            {
                ejs_trigger.job_id = ejs_job.id;
                JobSchedulerContext.jobs.AddIfNotExist(ejs_job);
                JobSchedulerContext.trigger.AddIfNotExist(ejs_trigger);
            }

        }
    }
}
