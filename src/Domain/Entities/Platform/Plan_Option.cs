using System;
using System.Collections.Generic;

namespace MVECloud.Domain.Entities.Platform {
    
    public class Plan_Option : AuditableEntity {
        public int id { get; set; }

        public Plan Plan { get; set;}

        public Option Option {get;set;}
    }
}