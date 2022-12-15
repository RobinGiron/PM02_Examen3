using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Extensions;

namespace PM2E30300.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPopupPage : Rg.Plugins.Popup.Pages.PopupPage
    {
        public MyPopupPage()
        {
            InitializeComponent();
        }

        private void PopupPage_BackgroundClicked(object sender, EventArgs e)
        {
            //DisplayAlert("Stop","holaa","OK");
            Navigation.PopPopupAsync();
        }

        private void Closebtn_Clicked(object sender, EventArgs e)
        {
            
        }

        private void orderBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnActualiza_Clicked(object sender, EventArgs e)
        {

        }
    }
}