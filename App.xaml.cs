using System;
using System.IO;
using UltimateAxisAndAlliesList.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UltimateAxisAndAlliesList
{
    public partial class App : Application
    {
        static LocationDatabase database;

        public static LocationDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new LocationDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Locations4.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new LocationsPage());
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
