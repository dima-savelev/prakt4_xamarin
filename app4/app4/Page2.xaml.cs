using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            if (switchToggle.IsToggled == true)
            {
                group1.IsEnabled = true;
                countryButton.IsEnabled = true;
            }
            else
            {
                group1.IsEnabled = false;
                countryButton.IsEnabled = false;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            RadioButton radioButton = default;
            foreach (var item in group1.Children)
            {
                if ((item as RadioButton).IsChecked == true)
                {
                    radioButton = item as RadioButton;
                    break;
                }
            }
            if (radioButton == null) return;
            switch (radioButton.Content)
            {
                case "Австрия":
                    country.Text = "Столица: Вена";
                    break;
                case "Болгария":
                    country.Text = "Столица: София";
                    break;
                case "Греция":
                    country.Text = "Столица: Афины";
                    break;
                case "Италия":
                    country.Text = "Столица: Венеция";
                    break;
                case "Норвегия":
                    country.Text = "Столица: Осло";
                    break;
                case "Польша":
                    country.Text = "Столица: Варшава";
                    break;
                case "Франция":
                    country.Text = "Столица: Париж";
                    break;
                case "Испания":
                    country.Text = "Столица: Мадрид";
                    break;
            }
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            country.Text = "Столица:";
        }
    }
}