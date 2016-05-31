using JobScheduler.Core.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobScheduler.Test
{
    public class HelloJob : IJob
    {
        public bool Excute()
        {
            Console.WriteLine("Hello EJS!", DateTime.Now.ToString());
            return true;
        }
    }
}
