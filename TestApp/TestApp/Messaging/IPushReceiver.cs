using System;

namespace TestApp.Messaging
{
    public interface IPushReceiver
    {
        event PushTokenRefreshEventHandler TokenRefresh;

        event PushReceivedEventHandler PushReceived;

        void HandlePushMessage(string from, string title, string body);
    }
}