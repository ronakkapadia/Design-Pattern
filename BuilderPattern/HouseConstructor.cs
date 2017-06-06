using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class HouseConstructor
    {
        public House ConstructConcreteHouse()
        {
            IHouseBuilder builder = new ConcreteHouseBuilder();
            builder.BuildBasement();
            builder.BuildInterior();
            builder.BuildStructure();
            builder.BuildRoof();
            return builder.GetHouse();
        }

        public House ConstructWoodenHouse()
        {
            IHouseBuilder builder = new WoodenHouseBuilder();
            builder.BuildBasement();
            builder.BuildInterior();
            builder.BuildStructure();
            builder.BuildRoof();
            return builder.GetHouse();
        }
    }
}
