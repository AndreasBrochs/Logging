using System;
using System.Threading;
using Serilog;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = new LoggerConfiguration()
             .WriteTo.Console()
             .CreateLogger();

            //TODO: log "Hello World!"
            log.Information("helloworld");
            var rand = new Random();
            bool runApp = true;
            Console.WriteLine("Press any key for pretty exit");
            while (runApp)
            {
                int randomSleep = rand.Next(1, 50);
                //TODO: log "Sleeping for 2.7 seconds"
                log.Information($"Sleeping for {SleepTimeToSec(randomSleep)}");
                //NOTE: use the SleepTimeToSec method to make the randomSleep human readable
                Thread.Sleep(randomSleep * 100);
                //TODO: log "Send data to Azure"
                log.Information("Send data på Azure");
                //TODO: send telemetry eg. "Telemetry data"
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    runApp = false;
                }
            }
            //TODO: log "Exit"
            log.Information("good bye");
            
        }

        static double SleepTimeToSec(int sleeptime)
        {
            double realtime = (double)sleeptime / 10;
            return realtime;
        }


    }
}
