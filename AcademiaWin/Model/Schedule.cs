using System.Collections.Generic;

namespace AcademiaWin.Model
{
    public class Schedule
    {
        private string Title { get; set; }
        private string Owner { get; set; }
        private string Comment { get; set; }
        List<Contact> Contacts { get; set; }
        List<Event> Events { get; set; }
        List<Note> Notes { get; set; }
    }
}
