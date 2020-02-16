using Microsoft.Azure.WebJobs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WebJobTest
{
    public class Timer
    {
        public static void Run(
            [TimerTrigger("* */1 * * * *")] TimerInfo timer,
            TextWriter logger)
        {
            logger.WriteLine($"Message triggered at {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
        }
    }
}
