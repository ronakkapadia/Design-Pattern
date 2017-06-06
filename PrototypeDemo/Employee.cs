using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDemo
{
    public class Employee : AbstractPrototype
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        public string Designation { get; set; }

        public override AbstractPrototype Clone()
        {
            return (AbstractPrototype)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Name={this.Name}\n Id={this.Id}\nSalary={this.Salary}\nDesignation={this.Designation}.";
        }
    }
}
