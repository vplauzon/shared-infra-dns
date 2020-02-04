using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace DnsFunction
{
    public static class DnsCheck
    {
        [FunctionName("DnsCheck")]
        public static void Run([TimerTrigger("0 */15 * * * *")]TimerInfo timer, ILogger log)
        {
            log.LogInformation($"Timer trigger function executed at: {DateTime.Now}");
        }
    }
}