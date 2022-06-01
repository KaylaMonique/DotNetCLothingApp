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
    public partial class Apparel : ContentPage
    {
        public Apparel()
        {
            InitializeComponent();
        }

        ScrollView scrollView = new ScrollView
        {
            VerticalOptions = LayoutOptions.FillAndExpand,
            Margin = new Thickness(10),
            Content = new Label
        };
    }
}