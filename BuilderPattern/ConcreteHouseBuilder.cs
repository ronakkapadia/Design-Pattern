using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ConcreteHouseBuilder : IHouseBuilder
    {
        private House house;

        public ConcreteHouseBuilder()
        {
            this.house = new House();
        }

        public void BuildBasement()
        {
            this.house.SetBasement("Concrete House Basement");
        }

        public void BuildInterior()
        {
            this.house.SetInterior("Concrete House Interior");
        }

        public void BuildStructure()
        {
            this.house.SetStructure("Concrete House Structure");
        }

        public void BuildRoof()
        {
            this.house.SetRoof("Concrete House Roof");
        }

        public House GetHouse()
        {
            return house;
        }
    }
}
