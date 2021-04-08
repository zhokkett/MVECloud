using System;

namespace MVECloud.Domain.Entities.Platform {
    
    public class Subscription: AuditableEntity {
        public int id { get; set; }

        public DateTime start { get; set; }

        public DateTime? end { get; set; }

        public Plan Plan { get; set; }

        public User_Account User_Account { get; set;}
    }
}