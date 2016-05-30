using JobScheduler.Data.Entry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobScheduler.Core.Trigger
{
    public class TriggerBuilder
    {
        private EJS_Trigger _trigger;
        private static TriggerBuilder _builder;


        public static TriggerBuilder Create()
        {
            _builder = new TriggerBuilder();
            _builder._trigger = new EJS_Trigger();
            return _builder;
        }

        public static TriggerBuilder Repeat()
        {
            _builder._trigger.is_repeatable = true;
            return _builder;
        }

        public static TriggerBuilder SetWeekOfDay(params DayOfWeek[] days)
        {
#warning need refatory
            _builder._trigger.dayofweeks = string.Join(",", days.Select(d => (int)d));
            return _builder;
        }

        public static TriggerBuilder SetStartHour(int hour)
        {
            _builder._trigger.start_time = DateTime.Now.Date.AddHours(hour);
            return _builder;
        }

        public EJS_Trigger Build()
        {
            return _trigger;
        }
    }
}
