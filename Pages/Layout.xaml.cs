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
using Windows.UI.Xaml.Media.Imaging;
using Assignment1.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Assignment1.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class layout : Page
    {
        public layout()
        {
            this.InitializeComponent();
        }
        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            SplitView_Menu.IsPaneOpen = !SplitView_Menu.IsPaneOpen;

        }
       
        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Menu item = listMenu.SelectedItem as Menu;
            switch (item.MenuPage)
            {
                case "Home":
                    MainFrame.Navigate(typeof(Pages.Home), "This is home");
                    break;
                case "Eat-in":
                    MainFrame.Navigate(typeof(Pages.Eat_In), "This is Eat-In");
                    break;
                case "Collection":
                    MainFrame.Navigate(typeof(Pages.Collection), "This is Collection");
                    break;
                case "Delivery":
                    MainFrame.Navigate(typeof(Pages.Delivery), "This is Delivery");
                    break;
                case "TakeAway":
                    MainFrame.Navigate(typeof(Pages.Take_Away), "This is Take-Away");
                    break;
                case "DriverPayment":
                    MainFrame.Navigate(typeof(Pages.Driver_Payment), "This is Driver-Payment");
                    break;
                case "Customers":
                    MainFrame.Navigate(typeof(Pages.Customer), "This is Customers");
                    break;

            }
        }
        private void BeeHead_Loaded(object sender, RoutedEventArgs e)
        {
            Image img = sender as Image;
            if (img != null)
            {
                BitmapImage bitmapImage = new BitmapImage();
                img.Width = bitmapImage.DecodePixelWidth = 280;
                bitmapImage.UriSource = new Uri("ms-appx:///Assets/jolibee.png");
                img.Source = bitmapImage;
            }
        }

        private void listMenu_Loaded(object sender, RoutedEventArgs e)
        {
            listMenu.Items.Add(new Menu { Name = "Home", MenuPage = "Home" });
            listMenu.Items.Add(new Menu { Name = "Eat-In", MenuPage = "Eat-In" });
            listMenu.Items.Add(new Menu { Name = "Collection", MenuPage = "Collection" });
            listMenu.Items.Add(new Menu { Name = "Delivery", MenuPage = "Delivery" });
            listMenu.Items.Add(new Menu { Name = "TakeAway", MenuPage = "TakeAway" });
            listMenu.Items.Add(new Menu { Name = "DriverPayment", MenuPage = "DriverPayment" });
            listMenu.Items.Add(new Menu { Name = "Customers", MenuPage = "Customers" });
        }
    }
}
