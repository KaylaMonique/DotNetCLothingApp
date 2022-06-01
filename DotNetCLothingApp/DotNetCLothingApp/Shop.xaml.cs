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

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MensApparel());
        }

        private async void TshirtButton_Clicked(object sender, EventArgs e)
        {

        }

        private  void PantsButton_Clicked(object sender, EventArgs e)
        {

        }

        private void ShoeButton_Clicked(object sender, EventArgs e)
        {

        }

        private void MenButton_Clicked(object sender, EventArgs e)
        {

        }

        private void WomanButton_Clicked(object sender, EventArgs e)
        {

        }

        private void ShoeButton_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}