﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.AbstractFactory
{
    public class DellFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new Dell();
        }

        public IProcessor Processor()
        {
            return new I5();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }

    public class DellLaptopFactory : DellFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}
