using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Hosting;
using System;

namespace WebJobTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello World the third! Date is {DateTime.Now:yyyy-MM-d dddd HH:mm:ss}");
            var builder = new HostBuilder();
            builder.ConfigureWebJobs(b =>
            {
                b.AddAzureStorageCoreServices();
                b.AddTimers();
            });
            var host = builder.Build();
            using (host)
            {
                host.Run();
            }
        }
    }
}
