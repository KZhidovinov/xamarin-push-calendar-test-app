using System.Threading.Tasks;

namespace TestApp.Messaging
{
    public delegate void PushTokenRefreshEventHandler(object target, PushTokenRefreshEventArgs args);
}