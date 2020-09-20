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
    public sealed partial class Foliage : Page
    {
        public Foliage()
        {
            this.InitializeComponent();
        }

        private void BOPBtn_Click(object sender, RoutedEventArgs e)
        {
            App.plantSelection = "Bird of Paradise";
            this.Frame.Navigate(typeof(PlantInfo), null);
        }

        private void MonsteraBtn_Click(object sender, RoutedEventArgs e)
        {
            App.plantSelection = "Monstera";
            this.Frame.Navigate(typeof(PlantInfo), null);
        }

        private void RubberTreeBtn_Click(object sender, RoutedEventArgs e)
        {
            App.plantSelection = "Rubber Tree";
            this.Frame.Navigate(typeof(PlantInfo), null); 
        }

        private void PeperomiaBtn_Click(object sender, RoutedEventArgs e)
        {
            App.plantSelection = "Raindrop";
            this.Frame.Navigate(typeof(PlantInfo), null);
        }

        private void PeaceLilyBtn_Click(object sender, RoutedEventArgs e)
        {
            App.plantSelection = "Peace Lily";
            this.Frame.Navigate(typeof(PlantInfo), null);
        }

        private void ZebrinaBtn_Click(object sender, RoutedEventArgs e)
        {
            App.plantSelection = "The Zebra Plant";
            this.Frame.Navigate(typeof(PlantInfo), null);
        }

        private void OrbifoliaBtn_Click(object sender, RoutedEventArgs e)
        {
            App.plantSelection = "Calathea Orbifolia";
            this.Frame.Navigate(typeof(PlantInfo), null);
        }

        private void SpiderBtn_Click(object sender, RoutedEventArgs e)
        {
            App.plantSelection = "Spider Plant";
            this.Frame.Navigate(typeof(PlantInfo), null);
        }

        private void Back_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomePage), null);
        }
    }
}
