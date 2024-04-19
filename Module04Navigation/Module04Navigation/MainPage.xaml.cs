using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module04Navigation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void onNextPageTabbed (object sender, EventArgs e)
        {
            await Navigation.PushAsync (new TabbedPage1());
        }

        private async void onNextPageCarousel (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CarouselPage1());
        } 
    }
}
