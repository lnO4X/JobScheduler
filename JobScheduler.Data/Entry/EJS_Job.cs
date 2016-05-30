using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobScheduler.Data.Entry
{
    public class EJS_Job
    {
        /// <summary>
        /// Job id
        /// </summary>
        public string id;
        /// <summary>
        /// job name
        /// </summary>
        public string name;
        public int status;

        public string job_class_name;

        /// <summary>
        /// have been run times
        /// </summary>
        public int run_times;

        public DateTime create_date;

        /// <summary>
        /// have been run times
        /// </summary>
        public DateTime next_start_date;
    }
}
