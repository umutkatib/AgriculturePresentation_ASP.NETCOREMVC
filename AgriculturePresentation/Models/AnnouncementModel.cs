using System;

namespace AgriculturePresentation.Models
{
    public class AnnouncementModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }
    }
}
