using Carca.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Carca.ViewModel
{
    public class ItemViewModel
    {
        private ObservableCollection<Item> items;
        private ObservableCollection<Item> Items
        {
            get { return items; }
            set { items = value; }
        }
        public ItemViewModel()
        {
            Items = new ObservableCollection<Item>()
            {
                new Item(){ Id = 1, Image ="home.png", Name ="pay Four" }
            
            };
         }

    }
}
