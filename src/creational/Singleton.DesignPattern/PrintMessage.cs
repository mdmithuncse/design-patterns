using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.DesignPattern
{
    public sealed class PrintMessage
    {
        private static PrintMessage? _instance = null;
        private int _count = 0;

        private static readonly object _locker = new object();

        private PrintMessage() 
        {
            _count++;
            Console.WriteLine($"Total number of instance #{_count}");
        }

        public static PrintMessage Instance
        {
            get
            {
                if (_instance is null)
                {
                    lock (_locker)
                    {
                        if (_instance is null)
                            _instance = new PrintMessage();
                    }
                }

                return _instance;
            }
        }

        public void Print(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentNullException("Invalid message input");

            Console.WriteLine(message);
        }
    }
}
