using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace JobScheduler.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            TestData a = new TestData();
            a.Init();
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {

                Console.WriteLine(Data.JobSchedulerContext.jobs.Count);
            }

            Console.ReadKey();
        }
    }
}
