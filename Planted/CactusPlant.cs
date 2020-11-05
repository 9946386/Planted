using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planted
{
    class CactusPlant : Plant
    {
        /// <summary>
        /// This Class is inherited from the Plant class
        /// With some additions
        /// </summary>

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
