using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AndroidApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeeEquipmentPage : ContentPage
    {
        public CoffeeEquipmentPage()
        {
            InitializeComponent();
            LabelCount.Text = "Hello User";
            ButtonClick.Clicked += ButtonClick_Clicked;
        }
        int count = 0;
        private void ButtonClick_Clicked(object sender, EventArgs e)
        {
            count++;

            LabelCount.Text = $"Вы нажали {count} раз"; 
        }
    }
}