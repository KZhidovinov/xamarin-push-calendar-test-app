using System;
using Android.Content;
using Android.Provider;
using Xamarin.Forms;

namespace TestApp.Droid
{
    public class CalendarWrapper : ICalendarWrapper
    {
        public void CreateEvent(long startTimeMS, long endTimeMS, string title, string description)
        {
            var intent = new Intent(Intent.ActionInsert);
            intent.SetType("vnd.android.cursor.dir/event")
                .PutExtra(CalendarContract.ExtraEventBeginTime, startTimeMS)
                .PutExtra(CalendarContract.ExtraEventEndTime, endTimeMS)
                .PutExtra(CalendarContract.ExtraEventAllDay, false)
                .PutExtra(CalendarContract.Events.InterfaceConsts.Title, title)
                .PutExtra(CalendarContract.Events.InterfaceConsts.Description, description);

            Forms.Context.StartActivity(intent);
        }
    }
}