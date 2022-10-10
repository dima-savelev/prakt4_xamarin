using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (check.IsChecked == true)
            {
                group1.IsEnabled = true;
            }
            else
            {
                group1.IsEnabled = false;
            }
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            switch(radioButton.Content)
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
    }
}