using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PM2E30300.test;
[assembly: ExportFont("Madani Arabic Semi Bold.ttf", Alias ="Madani-SemiBold")]
[assembly: ExportFont("Madani Arabic Bold.ttf", Alias = "Madani-Bold")]
[assembly: ExportFont("Madani Arabic Medium.ttf", Alias = "Madani-Medium")]
[assembly: ExportFont("Madani Arabic Regular.ttf", Alias = "Madani-Regular")]
[assembly: ExportFont("Madani Arabic Medium.ttf", Alias = "Madani-Medium")]
[assembly: ExportFont("AcherusGrotesque-RegularItalic.otf", Alias = "AcherusGrotesque-RegularItalic")]
[assembly: ExportFont("AcherusGrotesque-Regular.otf", Alias = "AcherusGrotesque-Regular")]

namespace PM2E30300
{
    public partial class App : Application
    {
        public App()
        {
            AdMaiora.RealXaml.Client.AppManager.Init(this);
            InitializeComponent();
            Device.SetFlags(new[] {"SwipeView_Experimental"});
            Device.SetFlags(new[] {"Expander_Experimental"});
            //MainPage = new MainPage();
            //MainPage = new NavigationPage(new RecordatoriosVistaPrevia());

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.White,
                BarTextColor = Color.Black,
            };

            //MainPage = new PaginaSwipe();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
