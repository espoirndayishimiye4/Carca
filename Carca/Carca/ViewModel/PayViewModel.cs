using Carca.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Carca.ViewModel
{
    internal class PayViewModel
    {
        private ObservableCollection<Pay> items;

        public ObservableCollection<Pay> Items { get { return items; }
            set
            {

                items = value;
            }
        }

        public PayViewModel()
        {


            Items = new ObservableCollection<Pay>();
                for (int i = 0; i < 10; i++) { 
                Items.Add(new Pay
                {

                    Name = "Payment Method",
                    Image = "home.png"
                });
            }
        }
    }
}
