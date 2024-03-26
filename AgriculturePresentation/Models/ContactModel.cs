using System;

namespace AgriculturePresentation.Models
{
    public class ContactModel
    {
        public int ContactID { get; set; }
        public string ContactName { get; set; }
        public string ContactMail { get; set; }
        public string ContactMessage { get; set; }
        public DateTime ContactDate { get; set; }
    }
}
