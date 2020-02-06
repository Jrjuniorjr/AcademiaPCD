using System;

namespace AcademiaWin
{
    [Serializable]
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Phone { get; set; }
        public string Adress { get; set; }
    }
}
