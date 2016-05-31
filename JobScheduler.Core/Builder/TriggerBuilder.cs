using JobScheduler.Core.Triggers;
using System;
using System.Linq;

namespace JobScheduler.Core.Builder
{
    public class TriggerBuilder
    {
        private Trigger _trigger;
        private static TriggerBuilder _builder;


        public static TriggerBuilder Create()
        {
            _builder = new TriggerBuilder();
            _builder._trigger = new Trigger();
            _builder._trigger.id = Guid.NewGuid().ToString();
            return _builder;
        }
        public TriggerBuilder SetIdentifiyName(string name)
        {
            _builder._trigger.name = name;
            return _builder;
        }


        public TriggerBuilder SetRepeat()
        {
            _builder._trigger.is_repeatable = true;
            return _builder;
        }

        public TriggerBuilder SetWeekOfDay(params DayOfWeek[] days)
        {
#warning need refatory
            _builder._trigger.dayofweeks = string.Join(",", days.Select(d => (int)d));
            return _builder;
        }

        public TriggerBuilder SetStartHour(int hour)
        {
            _builder._trigger.start_time = DateTime.Now.Date.AddHours(hour);
            return _builder;
        }

        public ITrigger Build()
        {
            return _trigger;
        }
    }
}
