using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Planted
{
    class Plant
    {
        public string PlantName { get; set; }
        public string ImageName { get; set; }
        public string ScientificName { get; set; }
        public string Watering { get; set; }
        public string Sunlight { get; set; }
        public string Temp { get; set; }
        public string Toxic { get; set; }
        public string Facts { get; set; }

        public Plant()
        {
            PlantName = "";
            ImageName = "";
            ScientificName = "";
            Watering = "";
            Sunlight = "";
            Temp = "";
            Toxic = "";
            Facts = "";
        }

        public Plant(string inputPlantName, string inputImageName, string inputScientificName, string inputWatering, string inputSunlight, string inputTemp, string inputToxic, string inputFacts)
        {
            PlantName = inputPlantName;
            ImageName = inputImageName;
            ScientificName = inputScientificName;
            Watering = inputWatering;
            Sunlight = inputSunlight;
            Temp = inputTemp;
            Toxic = inputToxic;
            Facts = inputFacts;
        }
    }
}
