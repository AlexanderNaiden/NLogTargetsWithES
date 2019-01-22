using System;
using Newtonsoft.Json;
using NLog;

namespace NLoggerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = LogManager.GetCurrentClassLogger();

            var message = new EventMessage
            {
                UserFullName = "Martin Huges",
                UserEmailAddress = "mhuges@yahoo.com",
                ApplicationInstanceName = "Application_Name Prod -",

                Browser = new UserBrowser
                {
                    BrowserUserAgentId = "Chrome",
                    EcmaScriptVersion = "3.0"
                }
            };

            var jsonToEs = JsonConvert.SerializeObject(message);
            logger.Log(LogLevel.Info, jsonToEs);

            LogManager.Flush();

            Console.ReadKey();
        }
    }
}
