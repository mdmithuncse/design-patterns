using DesignPatterns.AbstractFactory.AbstractFactory;
using DesignPatterns.AbstractFactory.Business;
using DesignPatterns.AbstractFactory.Models;
using System;

namespace DesignPatterns.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Employee employee = new Employee();
            IComputerFactory computerFactory = new EmployeeSystemFactory().Create(employee);
            EmployeeSystemManager manager = new EmployeeSystemManager(computerFactory);
            employee.ComputerDetails = manager.GetSystemDetails();
        }
    }
}
