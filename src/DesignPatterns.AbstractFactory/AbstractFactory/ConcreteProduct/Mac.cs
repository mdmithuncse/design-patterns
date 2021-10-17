using DesignPatterns.AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.AbstractFactory
{
    public class Mac : IBrand
    {
        public string GetBrand()
        {
            return Brands.Apple.ToString();
        }
    }
}
