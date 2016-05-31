using JobScheduler.Core.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobScheduler.Test
{
    public class TenSecondJob : IJob
    {
        public bool Excute()
        {
            Task.Delay(TimeSpan.FromSeconds(10)).Wait();
            return true;
        }
    }
}
