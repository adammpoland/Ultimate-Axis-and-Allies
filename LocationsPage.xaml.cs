using System;
using System.Collections.Generic;
using UltimateAxisAndAlliesList.Models;
using Xamarin.Forms;

namespace UltimateAxisAndAlliesList
{
    public partial class LocationsPage : ContentPage
    {
        public LocationsPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetLocationsAsync();
        }

        async void OnNoteAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LocationEntryPage
            {
                BindingContext = new Location()
            });
        }

        async void SearchByCountryClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchByCountry{});
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new LocationEntryPage
                {
                    BindingContext = e.SelectedItem as Location
                });
            }
        }
    }
}
