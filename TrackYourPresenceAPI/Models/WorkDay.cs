using System;

namespace TrackYourPresenceAPI.Models
{
    public class WorkDay
    {
        public int id { get; set; }
        public string Uuid { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime PauseTime { get; set; }
        public DateTime StopTime { get; set; }
    }
}