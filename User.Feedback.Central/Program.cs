using System;
using User.Feedback.Microservice.Run;

namespace User.Feedback.Central
{
    class Program
    {
        static void Main(string[] args)
        {
            var runner = new UserFeedbackRunner();
            runner.RunWithDefaultConfigFile(args, "config.yaml");

            Console.WriteLine("User.Feedback Central Application started.");
            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }
    }
}
