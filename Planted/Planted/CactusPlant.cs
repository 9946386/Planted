using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planted
{
    class CactusPlant : Plant
    {
        string Flowers { get; set; }
        string Spikes { get; set; }

        public CactusPlant()
        {
            Flowers = "";
            Spikes = "";
        }

        public CactusPlant(string inputFlowers, string inputSpikes)
        {
            Flowers = inputFlowers;
            Spikes = inputSpikes;
        }
    }
}
