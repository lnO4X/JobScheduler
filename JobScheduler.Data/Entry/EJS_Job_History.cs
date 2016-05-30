using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobScheduler.Data.Entry
{
    public class EJS_Job_History
    {
        /// <summary>
        /// history id
        /// </summary>
        public string id;
        /// <summary>
        /// job id
        /// </summary>
        public string job_id;

        public DateTime start_date;
        public DateTime finish_date;
        public DateTime create_date;
    }
}
