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
    public partial class Esmaspaev : ContentPage
    {
        public Esmaspaev()
        {
            StackLayout stack = new StackLayout();
            Button tagasi_btn = new Button { Text = "Tagasi" };
            stack.Children.Add(tagasi_btn);
            tagasi_btn.Clicked += new EventHandler(Batton_Clicked);
            Button edasi_btn = new Button { Text = "Tagasi" };
            stack.Children.Add(tagasi_btn);
            tagasi_btn.Clicked += new EventHandler(Batton_Clicked);
            Content = stack;
        }

        private async void Batton_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Text)
            {
                case "Tagasi":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Esmaspaev());
                    break;
            }
        }
    }
}