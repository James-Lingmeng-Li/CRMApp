using System;
using System.Collections.Generic;
using System.Text;

namespace CRMApp
{
    public class ApplicationDatabase
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("n");
        public DateTime cre_time { get; set; } = DateTime.UtcNow;
        public DateTime mod_time { get; set; } = DateTime.UtcNow;
        public string application_id { get; set; }
        public string applicant { get; set; }
        public int __v { get; set; }
        public string applicationType { get; set; }
    }
}



