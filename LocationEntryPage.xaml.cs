using System;
using System.Collections.Generic;
using UltimateAxisAndAlliesList.Models;
using Xamarin.Forms;

namespace UltimateAxisAndAlliesList
{
    public partial class LocationEntryPage : ContentPage
    {
        public LocationEntryPage()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var note = (Location)BindingContext;
            note.Date = DateTime.UtcNow;
            await App.Database.SaveLocationAsync(note);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var note = (Location)BindingContext;
            await App.Database.DeleteLocationAsync(note);
            await Navigation.PopAsync();
        }
    }
}
