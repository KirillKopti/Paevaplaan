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
    public partial class Neljapaev : ContentPage
    {
        public Neljapaev()
        {
            string[] tasks = new string[] { "Tõusen püsti", "Söön", "Lähene kooli", "Lähene koju", "Õhtu söök", "Lähen magama" };
            ListView list = new ListView();
            list.ItemsSource = tasks;
            list.ItemSelected += List_IntemSelected;
            Button back = new Button { Text = "Tagasi", BackgroundColor = Color.Blue, ImageSource = "back.ping" };
            back.Clicked += Back_Clicked;
            Button next = new Button { Text = "Edasi", BackgroundColor = Color.White, ImageSource = "next.ping" };
            next.Clicked += Next_Clicked;
            Content = new StackLayout { Children = { list, back, next } };
        }

        private async void Next_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Rede());
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        string kell;
        private async void List_IntemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                string text = e.SelectedItem.ToString();
                if (e.SelectedItemIndex == 0)//Tõusen püsti
                {
                    kell = "6:50";
                }
                else if (e.SelectedItemIndex == 1)//Söön
                {
                    kell = "7:15";
                }
                else if (e.SelectedItemIndex == 2)//Lähen kooli
                {
                    kell = "8:30";
                }
                else if (e.SelectedItemIndex == 3)//Lähen koju
                {
                    kell = "15;05";
                }
                else if (e.SelectedItemIndex == 4)//Õhtu söök
                {
                    kell = "17;45";
                }
                else if (e.SelectedItemIndex == 5)//Lähen magama
                {
                    kell = "22:00";
                }
                await DisplayAlert(kell, text, "jah");
            }
        }
    }
}