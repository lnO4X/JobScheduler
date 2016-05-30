using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobScheduler.Data.Entry
{
    public class EJS_Trigger
    {
        /// <summary>
        /// trigger id ,key
        /// </summary>
        public string id;
        /// <summary>
        /// job id
        /// </summary>
        public string job_id;


        /// <summary>
        /// job id
        /// </summary>
        public DateTime start_time;


        /// <summary>
        /// 重复或是一次
        /// </summary>
        public bool is_repeatable;


        /// <summary>
        /// run at day of weeks
        /// </summary>
        public string dayofweeks;

        public DateTime create_date;

    }
}
