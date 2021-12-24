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
    public partial class Settings : ContentPage
    {
        public ObservableCollection<Card> ListDetails{ get; set; }
        public Settings()
        {
            InitializeComponent();
            ListDetails = new ObservableCollection<Card>
            {
                new Card{ ImgIcon = "home.png", Name = "Payment Methods"}

            };
            BindingContext = this;
        }
    }
    public class Card
    {
        public string ImgIcon { get; set; }

        public string Name { get; set; }
    }
}