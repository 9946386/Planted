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
    public sealed partial class Succulent : Page
    {
        public Succulent()
        {
            this.InitializeComponent();
        }

        private void AloeBtn_Click(object sender, RoutedEventArgs e)
        {
            App.plantSelection = "Aloe Vera";

            this.Frame.Navigate(typeof(PlantInfo), null);
        }

        private void SOPBtn_Click(object sender, RoutedEventArgs e)
        {
            App.plantSelection = "String of Pearls";

            this.Frame.Navigate(typeof(PlantInfo), null);
        }

        private void SnakePlantBtn_Click(object sender, RoutedEventArgs e)
        {
            App.plantSelection = "Snake Plant";

            this.Frame.Navigate(typeof(PlantInfo), null);
        }

        private void Back_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomePage), null);
        }
    }
}
