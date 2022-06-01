using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DotNetCLothingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Shop : ContentPage
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
        private async void MenButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Apparel());

        }
        private async void WomanButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Apparel());

        }
    }
}