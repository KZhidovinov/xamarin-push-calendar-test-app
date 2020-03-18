using System;

namespace TestApp.Messaging
{
    public class PushReceivedEventArgs : EventArgs
    {
        public string From { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}