using Autofac;
using TestApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarPage : ContentPage
    {
        public CalendarPage()
        {
            InitializeComponent();
        }

        private void ButtonCreate_Clicked(object sender, System.EventArgs e)
        {
            var calendarWrapper = App.Container.Resolve<ICalendarWrapper>();
            var calEvent = this.BindingContext as CalendarEvent;

            calendarWrapper.CreateEvent(calEvent.StartTimeMS, calEvent.EndTimeMS, calEvent.Title, calEvent.Description);
        }
    }
}