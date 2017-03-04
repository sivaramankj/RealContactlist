using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactList.Models
{
    public class JQGridRequest
    {
        public bool _search { get; set; }
        public long? nd { get; set; }
        public int rows { get; set; }
        public int page { get; set; }
        public int? sidx { get; set; }
        public string sord { get; set; }
        public string filters { get; set; }
        public string searchField { get; set; }
        public string seachString { get; set; }
        public string searchOper { get; set; }
    }
}