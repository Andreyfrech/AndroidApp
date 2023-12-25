using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ZXing.Mobile;

namespace AndroidApp.ViewModels
{
    public class CoffeeEquipmentViewModel : BindableObject
    {
        public CoffeeEquipmentViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
        }   
       void OnIncrease()
        {
            count++;
            CountDisplay = $"Вы нажали {count} раз";
        }
    public ICommand IncreaseCount { get; }

        int count = 0;
        string countDisplay = "Нажми на меня";
        public string CountDisplay
        {
            get => countDisplay;
            set
            {
                if (value == countDisplay)
                    return;
                countDisplay = value;
                OnPropertyChanged();
            }
        }
    }
}
