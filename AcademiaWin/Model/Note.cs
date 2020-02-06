using System;

namespace AcademiaWin
{
    [Serializable]
    public class Note
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime DateHour { get; set; }
    }
}
