using NLog;
using System;

namespace NLogTest
{
    public class Program
    {
        private static readonly Logger logger =
            LogManager.GetCurrentClassLogger();

        public static void Main(string[] args)
        {
            logger.Info("Application start");

            try
            {
                throw new ArgumentException("error!");
            }
            catch (ArgumentException ex)
            {
                logger.Error(ex, "error thrown right after startup");
            }

            Console.WriteLine("Hello World!");

            logger.Info("Application shutting down");
        }
    }
}
