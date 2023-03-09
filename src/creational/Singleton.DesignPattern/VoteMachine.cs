using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.DesignPattern
{
    public sealed class VoteMachine
    {
        private static VoteMachine? _instance = null;
        private int _totalVotes = 0;

        private static readonly object _locker = new object();

        private VoteMachine() { }

        public static VoteMachine Instance
        { 
            get 
            {
                if (_instance is null)
                {
                    lock (_locker)
                    {
                        if(_instance is null)
                            _instance = new VoteMachine();
                    }
                }

                return _instance; 
            } 
        }

        public void RegisterVote()
        {
            _totalVotes += 1;
            Console.WriteLine($"Registered Vote #{_totalVotes}");
        }

        public int TotalVotes
        {
            get 
            { 
                return _totalVotes; 
            }
        }
    }
}
