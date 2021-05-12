using System;

namespace Interfaces
{
    public class Job : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("Job is running...");
        }
    }
}