using System;

namespace TestApp.Models
{
    public class CalendarEvent
    {
        public long StartTimeMS => (long)(StartDate.Date.Add(StartTime).ToUniversalTime()
            .Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds);
        public long EndTimeMS => (long)(EndDate.Date.Add(EndTime).ToUniversalTime()
            .Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds);
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
