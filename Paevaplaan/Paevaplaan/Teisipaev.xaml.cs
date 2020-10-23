using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Paevaplaan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Teisipaev : ContentPage
    {
        public Teisipaev()
        {
            string[] task = new string[] { "Tõusen püsti", "Söön", "Lähene kooli", "Lähene koju", "Söön", "Lähen magama" };
            ListView list = new ListView();
            list.ItemsSource = task;
            list.ItemSelected += List_IntemSelected;
            Content = new StackLayout{Children = { list } };
        }
        string kell;
        private async void List_IntemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem !=null)
            {
                string text = e.SelectedItem.ToString();
                if (e.SelectedItemIndex==0)
                {
                    kell = "7:00";
                }
                else if (e.SelectedItemIndex==1)
                {
                    kell = "8:00";
                }
            }   await DisplayAlert(kell, Text, "Jah");
        }
    }
}