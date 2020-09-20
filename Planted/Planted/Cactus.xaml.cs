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
    public sealed partial class Cactus : Page
    {
        public Cactus()
        {
            this.InitializeComponent();
        }

        private void BunnyEarsBtn_Click(object sender, RoutedEventArgs e)
        {
            App.plantSelection = "Bunny Ears";

            this.Frame.Navigate(typeof(PlantInfo), null);
        }

        private void EuphorbiaBtn_Click(object sender, RoutedEventArgs e)
        {
            App.plantSelection = "Euphorbia";

            this.Frame.Navigate(typeof(PlantInfo), null);
        }

        private void Back_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomePage), null);
        }
    }
}
