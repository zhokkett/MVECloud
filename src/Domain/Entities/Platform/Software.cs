using System;
using System.Collections.Generic;

namespace MVECloud.Domain.Entities.Platform {
    public class Software: AuditableEntity {
        public int id { get; set; }

        public string   name { get; set; }

        public string details { get; set; }

        public string access_link { get; set;}

        public ICollection<Plan> Plans {get;set;}
    }
}