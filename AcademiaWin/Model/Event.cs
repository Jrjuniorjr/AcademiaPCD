using System;

namespace AcademiaWin
{
    [Serializable]
    public class Event
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Local { get; set; }
    }
}
