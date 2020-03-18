using Autofac;
using TestApp.Messaging;
using TestApp.Models;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var pushReceiver = App.Container.Resolve<IPushReceiver>();
            pushReceiver.PushReceived += (o, args) =>
            {
                Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(new PushPage { BindingContext = args }));
            };
        }

        private async void ButtonCalendar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(
                new CalendarPage
                {
                    BindingContext =
                    new CalendarEvent
                    {
                        StartDate = DateTime.Today,
                        EndDate = DateTime.Today,
                        StartTime = DateTime.Now.AddHours(1).TimeOfDay,
                        EndTime = DateTime.Now.AddHours(2).TimeOfDay,
                        Title = "Title of example event",
                        Description = "Description of example event\nJust do it!"
                    }
                });
        }
    }
}