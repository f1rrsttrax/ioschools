using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ioschoolsWebsite.Models.admin
{
    public class ChangeLogViewModel
    {
        public IEnumerable<ChangeLog> changelogs { get; set; }
        public int total { get; set; }
    }
}