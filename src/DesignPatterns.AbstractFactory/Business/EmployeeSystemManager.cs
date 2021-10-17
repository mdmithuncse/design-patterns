using DesignPatterns.AbstractFactory.AbstractFactory;
using DesignPatterns.AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Business
{
    public class EmployeeSystemManager
    {
        IComputerFactory _computerFactory;

        public EmployeeSystemManager(IComputerFactory computerFactory)
        {
            _computerFactory = computerFactory;
        }

        public string GetSystemDetails()
        {
            IBrand brand = _computerFactory.Brand();
            IProcessor processor = _computerFactory.Processor();
            ISystemType systemType = _computerFactory.SystemType();

            return string.Format("{0} {1} {2}", brand.GetBrand(), processor.GetProcessor(), systemType.GetSystemType());
        }
    }
}
