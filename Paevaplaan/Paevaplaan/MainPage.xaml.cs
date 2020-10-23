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

            Button teisi_btn = new Button { Text = "Teisipäev" };
            stack.Children.Add(teisi_btn);
            teisi_btn.Clicked += new EventHandler(Batton_Clicked);

            Content = stack;

            Button kolma_btn = new Button { Text = "Kolmapäev" };
            stack.Children.Add(kolma_btn);
            kolma_btn.Clicked += new EventHandler(Batton_Clicked);

            Content = stack;

            Button nelja_btn = new Button { Text = "Neljapäev" };
            stack.Children.Add(nelja_btn);
            nelja_btn.Clicked += new EventHandler(Batton_Clicked);

            Content = stack;

            Button re_btn = new Button { Text = "Rede" };
            stack.Children.Add(re_btn);
            re_btn.Clicked += new EventHandler(Batton_Clicked);

            Content = stack;

            Button lau_btn = new Button { Text = "Laupäev" };
            stack.Children.Add(lau_btn);
            lau_btn.Clicked += new EventHandler(Batton_Clicked);

            Content = stack;

            Button puha_btn = new Button { Text = "Pühapäev" };
            stack.Children.Add(puha_btn);
            puha_btn.Clicked += new EventHandler(Batton_Clicked);

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

                case "Teisipäev":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Teisipaev());
                    break;

                case "Kolmapäev":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Kolmapaev());
                    break;

                case "Neljapäev":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Neljapaev());
                    break;

                case "Rede":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Rede());
                    break;

                case "Laupäev":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Laupaev());
                    break;

                case "Pühapäev":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Puhapaev());
                    break;
            }
        }
     }
}
