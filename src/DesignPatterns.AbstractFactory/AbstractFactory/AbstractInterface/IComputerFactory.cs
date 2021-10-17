using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.AbstractFactory
{
    public interface IComputerFactory
    {
        ISystemType SystemType();
        IBrand Brand();
        IProcessor Processor();
    }
}
