using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data.Domain;

namespace ContactList.Models
{
    public class ContactsVM
    {
        public int page { get; set; }
        public int total_pages { get; set; }
        public int records { get; set; }
        public IEnumerable<Contact> Contact { get; set; }
    }
}