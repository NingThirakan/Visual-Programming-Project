using BlueShopX.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlueShopX.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistPage : ContentPage
    {
        public RegistPage()
        {
            InitializeComponent();
        }

        private void Rbt_Clicked(object sender, EventArgs e)
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbPath);
            db.CreateTable<UserTable>();

            var item = new UserTable()
            {
                Username = EntryUsername.Text,
                Name = EntryName.Text,
                Password = EntryPassword.Text
            };

            db.Insert(item);

            if ((string.IsNullOrWhiteSpace(EntryUsername.Text)) || (string.IsNullOrEmpty(EntryUsername.Text)) ||
            (string.IsNullOrWhiteSpace(EntryPassword.Text)) || (string.IsNullOrEmpty(EntryPassword.Text)) ||
            (string.IsNullOrWhiteSpace(EntryName.Text)) || (string.IsNullOrEmpty(EntryName.Text)))
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Error", "Please Enter Data", "Cancel", "Yes");
                    if (result)
                    {
                        await Navigation.PushAsync(new RegistPage());
                    }
                    else
                    {
                        await Navigation.PushAsync(new RegistPage());
                    }
                });
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Successfull", "Registeration Successful", "Cancel", "Yes");
                    if (result)
                    {
                        App.Current.MainPage = new LoginPage();
                    }
                });

                Navigation.PushAsync(new LoginPage());
            }
        }
    }
}