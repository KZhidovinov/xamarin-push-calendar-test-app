using Android.Widget;
using TestApp.Messaging;
using Xamarin.Forms;

namespace TestApp.Droid
{
    public class PushReceiver : IPushReceiver
    {
        public event PushReceivedEventHandler PushReceived;
        public event PushTokenRefreshEventHandler TokenRefresh;

        public void HandlePushMessage(string from, string title, string body)
        {
            this.PushReceived(null, new PushReceivedEventArgs { From = from, Title = title, Body = body });
        }
    }
}