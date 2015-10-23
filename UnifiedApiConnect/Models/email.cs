using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnifiedApiConnect.Models
{
    public class Email
    {
        public string subject { get; set; }
        public string from { get; set; }
        public string body { get; set; }
        public int weight { get; set; }
        public int groupid { get; set; }
        public Group group { get; set; }
    }

    public class Group
    {
        public int groupid { get; set; }
        public string groupname { get; set; }
    }
}