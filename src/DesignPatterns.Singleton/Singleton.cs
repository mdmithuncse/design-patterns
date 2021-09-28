using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object lockObject = new object();
        private static int counter;

        private Singleton() 
        {
            counter++;
            Console.WriteLine($"Number of instance: {counter}");
        }

        public static Singleton GetInstance()
        {
            if (instance is null)
            {
                lock (lockObject)
                {
                    if (instance is null)
                    {
                        instance = new Singleton();
                    }
                }
            }

            return instance;
        }

        public void PrintDetails(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new Exception($"Invalid input: {nameof(message)}");

            Console.WriteLine(message);
        }
    }
}
