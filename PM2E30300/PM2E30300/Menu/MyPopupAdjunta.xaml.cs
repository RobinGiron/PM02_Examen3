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
    public partial class MyPopupAdjunta : Rg.Plugins.Popup.Pages.PopupPage
    {
        public MyPopupAdjunta()
        {
            InitializeComponent();
        }

        private void PopupPage_BackgroundClicked(object sender, EventArgs e)
        {
            Navigation.PopPopupAsync();
        }
    }
}