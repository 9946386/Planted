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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Planted
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PlantInfo : Page
    {
        /// <summary>
        ///  The dictionary to store all plant info that will display when selected by the user.
        ///  Each item in the dictionary contains the variables assigned to that inherited class.
        /// </summary>
        /// 
        Dictionary<string, Plant> plantDictionary = new Dictionary<string, Plant>()
        {
            {
                "Bird of Paradise", new FoliagePlant()
                {
                    PlantName="Bird of Paradise",
                    ImageName="/Assets/BirdOdParadise.png",
                    ScientificName="Strelitzia Reginae",
                    Watering="Soil should be kept moist through summer. Water less in coldermonths.",
                    Sunlight="Bright, indirect light",
                    Temp="Moderate temperatures all year round. Prefers to remain in the 21-32 degree range",
                    Toxic="Mildly toxic to cats and dogs",
                    Facts="The Strelitzia Reginae is a native to the eastern coastlines of sothern Africa. The plant grows to over 6 feet tall."
                }
            },

            {
                "Monstera", new FoliagePlant()
                {
                    PlantName="Monstera",
                    ImageName="/Assets/Monstera.png",
                    ScientificName="Monstera Deliciosa",
                    Watering="Every 1-2 weeks, allowing soil to dry out between waterings",
                    Sunlight="Bright, indirect light.",
                    Temp="18-29 degrees range. Best not to let it go below 15 degrees",
                    Toxic="Highly toxic to cats",
                    Facts="They are native to Central America. The plant gains its famous holes as they mature."
                }
            },

            {
                "Rubber Tree", new FoliagePlant()
                {
                    PlantName="Rubber Tree",
                    ImageName="/Assets/RubberTree.png",
                    ScientificName="Ficus Elastica",
                    Watering="Keep soil evenly moist.",
                    Sunlight="Bright, indirect light.",
                    Temp="Normal room temperature, 15-24 degrees.",
                    Toxic="Toxic to pets.",
                    Facts="Originated in India and Malaysia"
                }
            },

            {
                "Raindrop", new FoliagePlant()
                {
                    PlantName="Raindrop",
                    ImageName="/Assets/Peperomia.png",
                    ScientificName="Peperomia polybotrya",
                    Watering="Give a thorough drink but allow soil to dry out between watering",
                    Sunlight="High levels of sunlight",
                    Temp="Normal room temperatures, 15-24 degrees.",
                    Toxic="Low level toxicity",
                    Facts="A great plant to have in the home to help eliminate any airborne toxins in the air."
                }
            },

            {
                "Peace Lily", new FoliagePlant()
                {
                    PlantName="Peace Lily",
                    ImageName="/Assets/PeaceLily.png",
                    ScientificName="Spathiphyllum",
                    Watering="Well draining pot, keep the soil moist.",
                    Sunlight="Bright, indirect sunlight.",
                    Temp="Above 16 degrees.",
                    Toxic="If ingested, it can be mildly toxic.",
                    Facts="They produce beautiful long-lasting white flowers and make an excellent gift."
                }
            },

            {
                "The Zebra Plant", new FoliagePlant()
                {
                    PlantName="The Zebra Plant",
                    ImageName="/Assets/Zebrina.png",
                    ScientificName="Calathea Zebrina",
                    Watering="Keep the soil moist, slow down watering in winter",
                    Sunlight="Bright, shaded spot is ideal.",
                    Temp="Above 13 degrees",
                    Toxic="Not toxic to pets",
                    Facts="The Zebra plant produces purple or white inconspicuous flowers which are unlikely to appear indoors."
                }
            },

            {
                "Calathea Orbifolia", new FoliagePlant()
                {
                    PlantName="Orbofolia",
                    ImageName="/Assets/Orbofolia.png",
                    ScientificName="Calathea Orbifolia",
                    Watering="Little and often",
                    Sunlight="Diffused light, shielded from direct light.",
                    Temp="18-23 degrees.",
                    Toxic="Not toxic to pets.",
                    Facts="A great plant variety for helping to remove toxins from the air."
                }
            },

            {
                "Spider Plant", new FoliagePlant()
                {
                    PlantName="Spider Plant",
                    ImageName="/Assets/SpiderPlant",
                    ScientificName="Chlorophytum Comosum",
                    Watering="Keep well hydrated especially through the growing season.",
                    Sunlight="High levels of bright indirect light.",
                    Temp="Above 16 degrees",
                    Toxic="Considered toxic if ingested.",
                    Facts="Originated in South Africa. This plant is wonderful at helping to eliminate any airborne toxins in the home."
                }
            },

            {
                "Aloe Vera", new SucculentPlant()
                {
                    PlantName="Aloe",
                    ImageName="/Assets/Aloe.png",
                    ScientificName="Aloe Vera",
                    Watering="Keep soil moist. The plant retains a lot of water.",
                    Sunlight="Bright light conditions.",
                    Temp="26 degrees is good, don’t go below 10 degrees.",
                    Toxic="Toxic to cats and dogs.",
                    Flowers="Yellow flowers that can take 3-4 years to arrive.",
                    Facts="Aloe is known for its health and beauty benefits."
                }
            },

            {
                "String of Pearls", new SucculentPlant()
                {
                    PlantName="String of Pearls",
                    ImageName="/Assets/StringOfPearls-1.png",
                    ScientificName="Senecio rowleyanus",
                    Watering="Leave to dry out completely between watering.",
                    Sunlight="Prefers high levels of bright indirect sunlight.",
                    Temp="Warm room temperatures.",
                    Toxic="Mildly toxic if ingested.",
                    Flowers="Can produce small white flowers that smell like cinnamon.",
                    Facts="The String of Pearls is one of the most sought after plants with its unique trailing stems of pearl-like leaves."
                }
            },

            {
                "Snake Plant", new SucculentPlant()
                {
                    PlantName="Snake Plant",
                    ImageName="/Assets/SnakePlant.png",
                    ScientificName="Sansevieria trifasciata",
                    Watering="Allow the soil to dry out between watering.",
                    Sunlight="Moderate to high levels of sunlight.",
                    Temp="Normal room temperatures.",
                    Toxic="Mildly toxic if ingested.",
                    Flowers="No flowers",
                    Facts="A great plant to have in the home to eliminate airborne toxins."
                }
            },

            {
                "Bunny Ears", new CactusPlant()
                {
                    PlantName="Bunny Ears",
                    ImageName="/Assets/BunnyEars.png",
                    ScientificName="Opuntia Microdasys",
                    Watering="This is a desert species. Soil should be kept moist but not soggy",
                    Sunlight="Demands full light for growing most of the year",
                    Temp="High temperatures, 21-37 degrees",
                    Toxic="Can irritate skin",
                    Facts="The bunny ears is native to Northern Mexico and desert regions stretching into Arizona"
                }
            },

            {
                "Euphorbia", new CactusPlant()
                {
                    PlantName="Euphorbia Trigona",
                    ImageName="/Assets/Euphorbia.png",
                    ScientificName="Euphorbia Trigona",
                    Watering="Do not overwater. Keep the soil moist but not soggy",
                    Sunlight="Prefers bright light. Direct sun may burn the plant",
                    Temp="High temperatures",
                    Toxic="Sap can irritate skin",
                    Facts="This plant is also known as the African Milk Tree"
                }
            }

        };
        
        public PlantInfo()
        {
            this.InitializeComponent();

            /// An If Else statement to display an error message if the plant is not found 
            /// If the plant is found it will display the information from the dictionary 
            /// 

            if (plantDictionary.ContainsKey(App.plantSelection) == false)
            {
                PlantTitle.Text = "Plant not found"; ///Error message

                PlantInfoImage.Source = new BitmapImage(new Uri("/Assets/BirdOfParadiseBIG.png", UriKind.RelativeOrAbsolute));
            }
            else 
            {
                Plant thePlant = plantDictionary[App.plantSelection];

                PlantTitle.Text = thePlant.PlantName;
                PlantInfoImage.Source = new BitmapImage(new Uri(this.BaseUri, thePlant.ImageName));
                ScientificTitle.Text = thePlant.ScientificName;
                WateringText.Text = thePlant.Watering;
                SunlightText.Text = thePlant.Sunlight;
                TemperatureText.Text = thePlant.Temp;
                ToxicityText.Text = thePlant.Toxic;
                FactsText.Text = thePlant.Facts;                 
            }
        }

    }
}
