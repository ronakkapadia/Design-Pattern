using MobileManufacturer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileManufacturer.Factories
{
    public abstract class PhoneFactory
    {
        public abstract Mobile ProduceMobile();
    }
}
