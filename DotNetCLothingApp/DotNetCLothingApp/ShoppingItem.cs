using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DotNetCLothingApp
{
    public class ShoppingItem:INotifyPropertyChanged
    {
        [PrimaryKey, AutoIncrement]
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ImagePath { get; set; }
        public int ItemPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public string FormattedOrderDate

        { 
            get
            {
                return OrderDate.ToString();
            }
        }

        public string FormattedPrice

        {
            get
            {
                return $"R{ItemPrice.ToString()}";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
