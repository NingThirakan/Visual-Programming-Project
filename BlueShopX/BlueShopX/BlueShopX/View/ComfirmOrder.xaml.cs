using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlueShopX.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComfirmOrder : ContentPage
    {
        public ComfirmOrder()
        {
            InitializeComponent();
        }
        private void CFbt_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}