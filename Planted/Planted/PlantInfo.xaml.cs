using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Planted
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PlantInfo : Page
    {

        //Dictionary<string, Plant> plantDictionary = new Dictionary<string, Plant>()
        //{
        //    {
        //        "Bird of Paradise", new FoliagePlant()
        //        {
        //            PlantName="Bird of Paradise",
        //            ScientificName="Strelitzia Reginae",
        //            Watering="Soil should be kept moist through summer. Water less in coldermonths.",
        //            Sunlight="Bright, indirect light",
        //            Temp="Moderate temperatures all year round. Prefers to remain in the 21-32 degree range",
        //            Toxic="Mildly toxic to cats and dogs",
        //            Facts="The Strelitzia Reginae is a native to the eastern coastlines of sothern Africa. The plant grows to over 6 feet tall."
        //        }
        //    },

        //    {
        //        "Monsera", new FoliagePlant()
        //        {
        //            PlantName="Monstera",
        //            ScientificName="Monstera Deliciosa",
        //            Watering="Every 1-2 weeks, allowing soil to dry out between waterings",
        //            Sunlight="Bright, indirect light.",
        //            Temp="18-29 degrees range. Best not to let it go below 15 degrees",
        //            Toxic="Highly toxic to cats",
        //            Facts="They are native to Central America. The plant gains its famous holes as they mature."
        //        }
        //    },

        //    {
        //        "Rubber Tree", new FoliagePlant()
        //        {
        //            PlantName="Rubber Tree",
        //            ScientificName="Ficus Elastica",
        //            Watering="Keep soil evenly moist.",
        //            Sunlight="Bright, indirect light.",
        //            Temp="Normal room temperature, 15-24 degrees.",
        //            Toxic="Toxic to pets.",
        //            Facts="Originated in India and Malaysia"
        //        }
        //    },

        //    {
        //        "Raindrop", new FoliagePlant()
        //        {
        //            PlantName="Raindrop",
        //            ScientificName="Peperomia polybotrya",
        //            Watering="Give a thorough drink but allow soil to dry out between watering",
        //            Sunlight="High levels of sunlight",
        //            Temp="Normal room temperatures, 15-24 degrees.",
        //            Toxic="Low level toxicity",
        //            Facts="A great plant to have in the home to help eliminate any airborne toxins in the air."
        //        }
        //    },
        //};

        public PlantInfo()
        {
            this.InitializeComponent();
        }
    }
}
