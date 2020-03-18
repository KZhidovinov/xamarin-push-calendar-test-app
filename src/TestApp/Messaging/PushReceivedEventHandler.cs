using System.Threading.Tasks;

namespace TestApp.Messaging
{
    public delegate void PushReceivedEventHandler(object target, PushReceivedEventArgs args);
}