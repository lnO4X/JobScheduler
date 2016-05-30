using JobScheduler.Data.Entry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobScheduler.Core
{
    public class TestData
    {
        public static List<EJS_Job> jobs = new List<EJS_Job>();
        public static List<EJS_Trigger> triggers = new List<EJS_Trigger>();
        public static List<EJS_Job_History> histories = new List<EJS_Job_History>();
        public void Init()
        {
            for (int i = 0; i < 10; i++)
            {
                jobs.Add(new EJS_Job()
                {
                    id = Guid.NewGuid().ToString(),
                    create_date = DateTime.Now,
                    status = 1,
                    name = "job" + i,
                });
            }
            //for (int i = 0; i < jobs.Count; i++)
            //{
            //    triggers
            //}
        }
    }

}
