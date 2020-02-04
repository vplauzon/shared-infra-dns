using System;

public static void Run(TimerInfo timer, ILogger log)
{
    log.LogInformation($"Timer trigger function executed at: {DateTime.Now}");
}