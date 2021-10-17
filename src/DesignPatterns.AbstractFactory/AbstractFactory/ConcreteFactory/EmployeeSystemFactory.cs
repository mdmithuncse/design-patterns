using DesignPatterns.AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.AbstractFactory
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee emp)
        {
            IComputerFactory computerFactory = null;

            if (emp.EmployeeType == (int)EmployeeType.Permanent)
            {
                if (emp.DesignationType == (int)DesignationType.Managerial)
                {
                    computerFactory = new MacLaptopFactory();
                }

                else
                {
                    computerFactory = new MacFactory();
                }
            }

            else if (emp.EmployeeType == (int)EmployeeType.Contractual)
            {
                if (emp.DesignationType == (int)DesignationType.Managerial)
                {
                    computerFactory = new DellLaptopFactory();
                }

                else
                {
                    computerFactory = new DellFactory();
                }
            }

            return computerFactory;
        }
    }
}
