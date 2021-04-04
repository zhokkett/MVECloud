using System;

namespace MVECloud.Domain.Entities.Platform {
    public class Group: AuditableEntity {
        public int id { get; set; }

        public string name { get; set; }

        public Group_Type Group_Type;
    }
}