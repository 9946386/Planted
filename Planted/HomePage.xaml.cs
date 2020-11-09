using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class HomePage : Page
    {      

        public HomePage()
        {
            this.InitializeComponent();

        }

        /// Below are the buttons for displaying each plant type
        /// 

        #region Page Buttons 

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Frame.Navigate(typeof(Foliage));
            }
            catch 
            {
                ErrorMsg1.Text = "Error occurred when selecting Foliage Plants";
            }
            
        }

        private void SucculentsButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Frame.Navigate(typeof(Succulent));
            }
            catch
            {
                ErrorMsg2.Text = "Error occurred when selecting Succulent Plants";
            }
        }

        private void CactusButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Frame.Navigate(typeof(Cactus));
            }
            catch
            {
                ErrorMsg3.Text = "Error occurred when selecting Succulent Plants";
            }
        }

        #endregion

    }
}
