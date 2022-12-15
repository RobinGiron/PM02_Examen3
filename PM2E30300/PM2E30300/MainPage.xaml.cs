using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM2E30300
{
    [AdMaiora.RealXaml.Client.MainPage]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            AdMaiora.RealXaml.Client.AppManager.Init(this);
            InitializeComponent();
        }

        private async void btnvista_Clicked(object sender, EventArgs e)
        {
            RecordatoriosVistaPrevia vp = new RecordatoriosVistaPrevia();
            await Navigation.PushAsync(new RecordatoriosVistaPrevia());
        }

        private async void btnedit_Clicked(object sender, EventArgs e)
        {
            Object nota = new {
                id = 1,
                titulo = "NOTA1",
                contenido = "HOLA COMO ESTAS AMIGO AKI MOSTRANDO LA NOTA NUMERO 1",
                tengoAudio = false,
                tengoFoto = false
            };
            RecordatoriosEditar pag = new RecordatoriosEditar();
            pag.BindingContext = nota;
            await Navigation.PushAsync(pag);
        }

        private async void btnmenu_Clicked(object sender, EventArgs e)
        {
            Menu.FlyoutPage1 flyy = new Menu.FlyoutPage1();
            //flyy.Detail.BackgroundColor = Color.White;
            //flyy.Detail.Title = "holaa";
            //flyy.Flyout.BackgroundColor = Color.White;
            await Navigation.PushModalAsync(flyy);
        }

        private async void btnmenu2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new test.PaginaSwipe());
        }

        private async void btnpage1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new test.Page1());
        }
    }
}
