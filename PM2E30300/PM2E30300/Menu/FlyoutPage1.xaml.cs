using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2E30300.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutPage1 : FlyoutPage
    {
        public FlyoutPage1()
        {
            InitializeComponent();
            FlyoutPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as FlyoutPage1FlyoutMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.BackgroundColor = Color.White;
            page.Title = item.Title;

            //Detail = new NavigationPage(page);
            Detail = new NavigationPage(page)
            {
                BarBackgroundColor = Color.White,
                BarTextColor = Color.Black
            };
            IsPresented = false;

            FlyoutPage.ListView.SelectedItem = null;
        }
    }
}