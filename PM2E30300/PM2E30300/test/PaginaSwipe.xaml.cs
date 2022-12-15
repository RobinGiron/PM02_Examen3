using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Extensions;
using PM2E30300.Menu;
using System.Windows.Input;
using PM2E30300.Models;
using System.Collections.ObjectModel;

namespace PM2E30300.test
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(false)]
    public partial class PaginaSwipe : ContentPage
    {
        public bool abiertoMenu = false;
        public Command TouchCommand { get; }
        public ObservableCollection<Notas> noti { get; set; }
        public PaginaSwipe()
        {
            InitializeComponent();
            MyMenu = GetMenus();
            noti = new ObservableCollection<Notas>
            {
                new Notas
                {
                    id=1,
                    titulo= "NOTA1",
                    contenido="hola como estas",
                    fecha= new DateTime(),
                    foto="foto",
                    audio="audio",
                    firma="firma",
                    favorito= 1,
                    estado="ACTIVO",
                    usuarioID= 1,
                    latitud="16.1",
                    longitud="-15.8",
                    fecha_ULT_mod= new DateTime()
                },
                new Notas
                {
                    id=2,
                    titulo= "NOTA2",
                    contenido="aki bien y tu",
                    fecha= new DateTime(),
                    audio="audio",
                    firma="firma",
                    favorito= 1,
                    estado="ACTIVO",
                    usuarioID= 1,
                    latitud="16.1",
                    longitud="-15.8",
                    fecha_ULT_mod= new DateTime()
                },
                new Notas
                {
                    id=3,
                    titulo= "NOTA3",
                    contenido="jejeje",
                    fecha= new DateTime(),
                    foto="foto",
                    audio="audio",
                    firma="firma",
                    favorito= 1,
                    estado="ACTIVO",
                    usuarioID= 1,
                    latitud="16.1",
                    longitud="-15.8",
                    fecha_ULT_mod= new DateTime()
                }
            };
            //ListaNotas.ItemsSource = noti;
            TouchCommand = new Command(() => DisplayAlert("INFO", "HOLA COMO ESTAS", "OK"));
            BindingContext = this;
        }
        private void OpenSwipe(object sender, EventArgs e)
        {
            if (abiertoMenu)
            {
                abiertoMenu = false;
                Swipemenu.Close();
                CloseAnimation();
            }
            else
            {
                abiertoMenu = true;
                OpenAnimation();
                Swipemenu.Open(OpenSwipeItem.LeftItems);
            }
        }

        private void CloseSwipe(object sender, EventArgs e)
        {
            if (abiertoMenu)
            {
                abiertoMenu = false;
                Swipemenu.Close();
                CloseAnimation();
            }
            else
            {
                abiertoMenu = true;
                OpenAnimation();
                Swipemenu.Open(OpenSwipeItem.LeftItems);
            }
        }
        public List<Menu> MyMenu { get; set; }
        private List<Menu> GetMenus()
        {
            return new List<Menu>
            {
                new Menu{ name = "INICIO" ,Icon="home.png"},
                new Menu{ name = "PERFIL" ,Icon="user_male_26px.png"},
                new Menu{ name = "RECORDATORIOS" ,Icon="notification_26px.png"},
                new Menu{ name = "NOTAS" ,Icon="page_26px.png"},
                new Menu{ name = "FAVORITOS" ,Icon="favorite.png"},
                new Menu{ name = "PAPELERA" ,Icon="papelera.png"},
                new Menu{ name = "CONFIGURACION" ,Icon="config.png"}
            };
        }
        private async void OpenAnimation()
        {
            await SwipeContent.ScaleYTo(0.9, 300, Easing.SinOut);
            await SwipeContent.RotateTo(-15, 300, Easing.SinOut);
            pancake.CornerRadius = 20;
        }
        private async void CloseAnimation()
        {
            await SwipeContent.ScaleYTo(1, 300, Easing.SinOut);
            await SwipeContent.RotateTo(0, 300, Easing.SinOut);
            pancake.CornerRadius = 0;
        }

        private void Swipemenu_SwipeStarted_1(object sender, SwipeStartedEventArgs e)
        {
            if (abiertoMenu)
            {
                abiertoMenu = false;
                Swipemenu.Close();
                CloseAnimation();
            }
            else
            {
                abiertoMenu = true;
                OpenAnimation();
                Swipemenu.Open(OpenSwipeItem.LeftItems);
            }
        }

        private void Swipemenu_SwipeEnded_1(object sender, SwipeEndedEventArgs e)
        {
            if (!e.IsOpen)
            {
                if (abiertoMenu)
                {
                    abiertoMenu = false;
                    Swipemenu.Close();
                    CloseAnimation();
                }
                else
                {
                    abiertoMenu = true;
                    OpenAnimation();
                    Swipemenu.Open(OpenSwipeItem.LeftItems);
                }
            }
            else
            {
                if (abiertoMenu)
                {
                    abiertoMenu = false;
                    Swipemenu.Close();
                    CloseAnimation();
                }
                else
                {
                    abiertoMenu = true;
                    OpenAnimation();
                    Swipemenu.Open(OpenSwipeItem.LeftItems);
                }
            }
        }

        private void Swipemenu_SwipeChanging(object sender, SwipeChangingEventArgs e)
        {
            //if (e.SwipeDirection == SwipeDirection.Right)
            //{
            //    CloseAnimation();
            //}
            //else if (e.SwipeDirection == SwipeDirection.Left)
            //{
            //    OpenAnimation();
            //}
        }

        private void Swipemenu_CloseRequested(object sender, CloseRequestedEventArgs e)
        {
            CloseAnimation();
        }

        private async void Click_User(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new UpdateUser());
        }

        private async void Click_More(object sender, EventArgs e)
        {
            await Navigation.PushPopupAsync(new MyPopupPage());
        }

        private async void ClickNew(object sender, EventArgs e)
        {
            await DisplayAlert("INFO", "HOLAAA", "OK");
        }
        private void ClickaNota_Tapped(object sender, EventArgs e)
        {
            StackLayout ab = sender as StackLayout;
            Frame aa = ab.Parent as Frame;
            if (aa.Scale != 1)
            {
                //aa.BackgroundColor = new Color(63, 63, 63);
                aa.ScaleTo(1, 300, Easing.SinIn);
                //aa.ScaleXTo(1, 300, Easing.SinIn);
            }
            else
            {
                //aa.BackgroundColor = new Color(127, 127, 127);
                aa.ScaleTo(1.05, 300, Easing.SinIn);
                //aa.ScaleXTo(1.05, 300, Easing.SinIn);
            }
        }

        private void BuscadordeNotas_TextChanged(object sender, TextChangedEventArgs e)
        {
            var currentSearchText = e.NewTextValue.ToLowerInvariant();
            if (string.IsNullOrWhiteSpace(currentSearchText))
            {
                currentSearchText = string.Empty;
            }
            //var filto = noti.Where(a => a.titulo.StartsWith(e.NewTextValue));
            var filto = noti.Where(a => a.titulo.ToLowerInvariant().Contains(currentSearchText)).ToList();
            ListaNotas.ItemsSource = filto;
        }
        //private void Swipemenu_CloseRequested(object sender, CloseRequestedEventArgs e)
        //{
        //    CloseAnimation();
        //}
    }
    public class Menu
    {
        public string name { get; set; }
        public string Icon { get; set; }
    }
}