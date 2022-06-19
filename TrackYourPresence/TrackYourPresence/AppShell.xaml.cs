﻿using System;
using TrackYourPresence.Views;
using TrackYourPresence.Views.Workdays;
using Xamarin.Forms;

namespace TrackYourPresence
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }

        private void RegisterRoutes()
        {
            // Absent
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            
            // WorkDays
            Routing.RegisterRoute(nameof(WorkDayDetailPage), typeof(WorkDayDetailPage));
            Routing.RegisterRoute(nameof(NewWorkDayPage), typeof(NewWorkDayPage));
        }
    }
}
