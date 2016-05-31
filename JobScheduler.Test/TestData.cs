using JobScheduler.Core.Builder;
using JobScheduler.Core.Job;
using JobScheduler.Core.Schedulers;

namespace JobScheduler.Test
{
    public class TestData
    {
        public void Init()
        {
            var scheduler = SchedulerFactory.GetScheduler("testscheduler", 1);
            for (int i = 0; i < 10; i++)
            {
                IJobDetail job;
                if (i < 5)
                    job = JobBuilder.Create<HelloJob>().SetIdentifiyName("hello job" + i).Build();
                else job = JobBuilder.Create<TenSecondJob>().SetIdentifiyName("10s job" + i).Build();
                var trigger = TriggerBuilder.Create().SetIdentifiyName("trigger" + i).SetRepeat().SetStartHour(12).Build();
                scheduler.SchedulerJob(job, trigger);
            }
        }
    }

}
