
namespace TestApp
{
    public interface ICalendarWrapper
    {
        void CreateEvent(long startTimeMS, long endTimeMS, string title, string description);
    }
}
