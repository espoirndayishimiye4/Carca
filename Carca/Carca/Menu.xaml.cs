using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Carca
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public ObservableCollection<Liste> ListDetails { get; set; }
        public Menu()
        {
            InitializeComponent();

       
            List<String> card = new List<String>();

            for (int i = 0; i < 10; i++) { 
            card.Add("Card");
            }
            BindingContext = card;
            ListDetails = new ObservableCollection<Liste>
            {
                    

                new Liste{ Image = "home.png", Name = "Payment Methods"},
                new Liste{ Image = "home.png", Name = "Payment Methods"},
                new Liste{ Image = "home.png", Name = "Payment Methods"},
                new Liste{ Image = "home.png", Name = "Payment Methods"},

            };
                BindingContext = this;
            }
        
    }
    public class Liste
    {
        public string Image { get; set; }

        public string Name { get; set; }
    }
}