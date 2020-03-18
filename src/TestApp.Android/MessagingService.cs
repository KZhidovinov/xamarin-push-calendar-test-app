using Android.App;
using Android.Util;
using Autofac;
using Firebase.Messaging;
using TestApp.Messaging;

namespace TestApp.Droid
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" })]
    public class MessagingService : FirebaseMessagingService
    {
        const string TAG = "MessagingService";

        public override void OnNewToken(string newToken)
        {
            base.OnNewToken(newToken);
            Log.Debug(TAG, $"Refresh token: {newToken}");
        }

        public override void OnMessageReceived(RemoteMessage receivedMessage)
        {
            base.OnMessageReceived(receivedMessage);

            var from = receivedMessage.From;
            var title = receivedMessage.GetNotification().Title;
            var body = receivedMessage.GetNotification().Body;

            var handler = App.Container.Resolve<IPushReceiver>();
            handler.HandlePushMessage(from, title, body);
        }
    }
}