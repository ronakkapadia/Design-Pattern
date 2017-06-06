using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{    
    public class WoodenHouseBuilder : IHouseBuilder
    {
        private House house;

        public WoodenHouseBuilder()
        {
            this.house = new House();
        }

        public void BuildBasement()
        {
            this.house.SetBasement("Wooden House Basement");
        }

        public void BuildInterior()
        {
            this.house.SetInterior("Wooden House Interior");
        }

        public void BuildStructure()
        {
            this.house.SetStructure("Wooden House Structure");
        }

        public void BuildRoof()
        {
            this.house.SetRoof("Wooden House Roof");
        }

        public House GetHouse()
        {
            return house;
        }
    }
}
