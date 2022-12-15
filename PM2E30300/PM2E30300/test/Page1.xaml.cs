using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2E30300.test
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Command TouchCommand { get; }
        public Page1()
        {
            InitializeComponent();
            TouchCommand = new Command(()=>DisplayAlert("INFO","HOLA COMO ESTAS","OK"));
            BindingContext=this;
        }
    }
}