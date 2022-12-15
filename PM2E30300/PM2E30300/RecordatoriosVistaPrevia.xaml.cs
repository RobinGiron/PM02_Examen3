using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2E30300
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecordatoriosVistaPrevia : ContentPage
    {
        public RecordatoriosVistaPrevia()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Image item = sender as Image;
            //IMAGEN 
            try
            {
                await Share.RequestAsync(new ShareTextRequest
                {
                    Title = "FOTO",
                    Text="AKI VA LA FOTO COMO ShareFile",
                    Subject="ENVIAR FOTO",
                    Uri="http://www.google.hn"
                });
            }
            catch (Exception) 
            {
                await DisplayAlert("ERROR", "ERROR AL COMPARTIR LA FOTO", "OK");
            }
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            //AUDIO
            try
            {
                await Share.RequestAsync(new ShareTextRequest
                {
                    Title = "AUDIO",
                    Text = "AKI VA EL AUDIO",
                    Subject = "ENVIAR AUDIO",
                    Uri = "http://www.audio.hn"
                });
            }
            catch (Exception)
            {
                await DisplayAlert("ERROR", "ERROR AL COMPARTIR EL VIDEO", "OK");
            }
        }
        private async void btnedit_Clicked(object sender, EventArgs e)
        {
            Object nota = new
            {
                id = 1,
                titulo = "NOTA1",
                contenido = "HOLA COMO ESTAS AMIGO AKI MOSTRANDO LA NOTA NUMERO 1",
                tengoAudio = false,
                tengoFoto = false
            };
            RecordatoriosEditar pag = new RecordatoriosEditar();
            pag.BindingContext = nota;
            //demostracion enviando id de recordatorio
            await Navigation.PushAsync(pag);
        }

        private void btnview_Clicked(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnaddToFav_Clicked(object sender, EventArgs e)
        {

        }
    }
}