using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planted
{
    class SucculentPlant : Plant
    {
        public string Flowers { get; set; }

        public SucculentPlant()
        {
            Flowers = "";
        }

        public SucculentPlant(string inputFlowers)
        {
            Flowers = inputFlowers;
        }
    }
}
