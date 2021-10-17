using DesignPatterns.AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.AbstractFactory
{
    public class I7 : IProcessor
    {
        public string GetProcessor()
        {
            return Processors.I7.ToString();
        }
    }

    public class I5 : IProcessor
    {
        public string GetProcessor()
        {
            return Processors.I5.ToString();
        }
    }

    public class I3 : IProcessor
    {
        public string GetProcessor()
        {
            return Processors.I3.ToString();
        }
    }
}
