using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class House : IHousePlan
    {
        private string basement;

        private string structure;

        private string roof;

        private string interior;

        public void SetBasement(string basement)
        {
            Console.WriteLine(basement);
            this.basement = basement;
        }

        public void SetInterior(string interior)
        {
            Console.WriteLine(interior);
            this.interior = interior;
        }

        public void SetRoof(string roof)
        {
            Console.WriteLine(roof);
            this.roof = roof;
        }

        public void SetStructure(string structure)
        {
            Console.WriteLine(structure);
            this.structure = structure;
        }
    }
}
