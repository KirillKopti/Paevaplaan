using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Paevaplaan
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            StackLayout stack = new StackLayout();
            Button esmas_btn = new Button { Text = "Esmaspäev" };
            stack.Children.Add(esmas_btn);
            esmas_btn.Clicked += new EventHandler(Batton_Clicked);

            Content = stack;
        }

        private async void Batton_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Text)
            {
                case "Esmaspäev":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Esmaspaev());
                    break;

            }
        }
     }
}
