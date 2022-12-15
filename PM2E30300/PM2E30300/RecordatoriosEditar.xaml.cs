using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2E30300
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecordatoriosEditar : ContentPage, ISearchPage
    {
        public RecordatoriosEditar()
        {
            InitializeComponent();
            SearchBarTextChanged += HandleSearchBarTextChanged;
        }

        public event EventHandler<string> SearchBarTextChanged;
        //void ISearchPage.OnSearchBarTextChanged((string text) => SearchBarTextChanged?.Invoke(this, text);
        void HandleSearchBarTextChanged(object sender, string searchBarText)
        {
            //Logic to handle updated search bar text
        }
        private void Back_Click(object sender, EventArgs e)
        {

        }

        private void Click_More(object sender, EventArgs e)
        {

        }

        private async void Adjunta_Click(object sender, EventArgs e)
        {
            await Navigation.PushPopupAsync(new Menu.MyPopupAdjunta());
        }

        private void Moreclick(object sender, EventArgs e)
        {

        }

        private void Shareclick(object sender, EventArgs e)
        {

        }

        private void toFavClick(object sender, EventArgs e)
        {

        }

        public void OnSearchBarTextChanged(string text)
        {
            throw new NotImplementedException();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }
    }
}