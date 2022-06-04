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
        public List<ShoppingItem> Items { get; set; }
        public Apparel()
        {
            InitializeComponent();

            Items = new List<ShoppingItem>();

            var item = new ShoppingItem()
            {
                ItemID = 1023,
                ItemName = "Comfy Pants",
                ImagePath = "pants1.jpg",
                ItemPrice = 150,
            };

            Items.Add(item);

            item = new ShoppingItem
            {
                ItemID = 1024,
                ItemName = "Comfy Pants",
                ImagePath = "pants2.jpg",
                ItemPrice = 150,
            };

            Items.Add(item);

            item = new ShoppingItem
            {
                ItemID = 1025,
                ItemName = "Comfy Pants",
                ImagePath = "pants3.jpg",
                ItemPrice = 150,
            };

            Items.Add(item);


            item = new ShoppingItem
            {
                ItemID = 1026,
                ItemName = "#Nettie Tee",
                ImagePath = "tee.jpeg",
                ItemPrice = 200,
            };

            Items.Add(item);

            item = new ShoppingItem
            {
                ItemID = 1027,
                ItemName = "Don't Panic Tee",
                ImagePath = "tee1.jpeg",
                ItemPrice = 200,
            };

            Items.Add(item);

            item = new ShoppingItem
            {
                ItemID = 1028,
                ItemName = "The Power of .Net Developer tee",
                ImagePath = "tee2.jpeg",
                ItemPrice = 250,
            };

            Items.Add(item);

            item = new ShoppingItem
            {
                ItemID = 1029,
                ItemName = "Airforce 1 High",
                ImagePath = "shoe1.jpg",
                ItemPrice = 2000,
            };

            Items.Add(item);

            item = new ShoppingItem
            {
                ItemID = 1030,
                ItemName = "Nike Huarche",
                ImagePath = "shoe2.jpg",
                ItemPrice = 1500,
            };

            Items.Add(item);

            item = new ShoppingItem
            {
                ItemID = 1031,
                ItemName = "Airmax 90",
                ImagePath = "shoe3.jpg",
                ItemPrice = 1500,
            };

            Items.Add(item);

            BindingContext = this;
        }
    }
}