using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PirmeraClase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class inicio : ContentPage
    {
        public inicio()
        {
            InitializeComponent();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new Pagina2());
        }

        private async void ButtonGoPagina2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pagina2());
        }
    }
}