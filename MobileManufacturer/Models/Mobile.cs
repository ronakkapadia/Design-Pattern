using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileManufacturer.Models
{
    public abstract class Mobile
    {
        public Mobile(string model,double price)
        {
            this.Model = model;
            this.Price = price;
        }
        public string Model { get; set; }
        public double Price { get; set; }

        public abstract void Call();
    }
}
