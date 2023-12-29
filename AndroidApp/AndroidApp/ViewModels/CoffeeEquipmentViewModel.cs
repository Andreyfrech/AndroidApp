using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ZXing;
using ZXing.Mobile;

namespace AndroidApp.ViewModels
{
    public class CoffeeEquipmentViewModel : BindableObject
    {
        public CoffeeEquipmentViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
            ScanBarCode = new Command(OnScanBarCode);
            ScanBarCodeVisible = new Command(OnScanBarCodeVisible);

		}   
       void OnIncrease()
        {
            count++;
            CountDisplay = $"Вы нажали {count} раз";
        }
		void OnScanBarCode()
		{
			Device.BeginInvokeOnMainThread(() =>
			{
				BarCode = result.Text + " (type: " + result.BarcodeFormat.ToString() + ") ";
				IsScann = !IsScann;
			});
			
		}
        void OnScanBarCodeVisible()
        {
			ScanVisible = !ScanVisible;
            
		}
		public ICommand IncreaseCount { get; }
        public ICommand ScanBarCode { get; }
        public ICommand ScanBarCodeVisible { get; }
		public ZXing.Result result { get; set; }

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

        string barCode = "";
		public string BarCode
		{
			get => barCode;
			set
			{
				if (value == barCode)
					return;
				barCode = value;
				OnPropertyChanged();
			}
		}

        bool scanVisible = false;
        public bool ScanVisible
        {
            get => scanVisible;
            set
            {
                if(value == scanVisible) return;
                scanVisible = value;
                OnPropertyChanged();
            }
        }
        bool isScann = false;
        public bool IsScann
        {
            get => isScann;
            set
            {
                if (value == isScann) return;
                isScann = value;
                OnPropertyChanged();
            }
        }
	}
}
