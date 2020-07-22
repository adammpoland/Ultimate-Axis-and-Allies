using System;
using System.Collections.Generic;
using UltimateAxisAndAlliesList.Models;
using Xamarin.Forms;

namespace UltimateAxisAndAlliesList
{
    public partial class SearchByCountry : ContentPage
    {
        public SearchByCountry()
        {
            InitializeComponent();
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

         async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (Territories.SelectedItem.ToString() != "")
            {
                listView.ItemsSource = await App.Database.GetLocationsAsync(Territories.SelectedItem.ToString());

            }

        }
    }
}
