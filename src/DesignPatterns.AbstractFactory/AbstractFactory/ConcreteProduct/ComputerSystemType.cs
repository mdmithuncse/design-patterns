using DesignPatterns.AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.AbstractFactory
{
    public class Desktop : ISystemType
    {
        public string GetSystemType()
        {
            return SystemTypes.Desktop.ToString();
        }
    }

    public class Laptop : ISystemType
    {
        public string GetSystemType()
        {
            return SystemTypes.Laptop.ToString();
        }
    }
}
