using JobScheduler.Data.Entry;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobScheduler.Data
{
    public class JobSchedulerContext : DbContext
    {
#warning test data before add db partition
        public static List<EJS_Job> jobs = new List<EJS_Job>();
        public static List<EJS_Job_History> historys = new List<EJS_Job_History>();
        public static List<EJS_Scheduler> schedulers = new List<EJS_Scheduler>();
        public static List<EJS_Trigger> trigger = new List<EJS_Trigger>();
    }
}
