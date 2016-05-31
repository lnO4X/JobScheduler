using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobScheduler.Core.Schedulers
{
    public class SchedulerFactory
    {
        private static Dictionary<string, Scheduler> _scheduler = new Dictionary<string, Scheduler>();
        public static IScheduler GetScheduler(string name, object instance_id)
        {
            _scheduler[name] = new Scheduler()
            {
                name = name,
                instance_id = instance_id.ToString(),
            };
            return _scheduler[name];
        }
    }
}
