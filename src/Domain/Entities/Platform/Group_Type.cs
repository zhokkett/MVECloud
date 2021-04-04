using System;
using System.Collections.Generic;

namespace MVECloud.Domain.Entities.Platform {
    public class Group_Type : AuditableEntity {
        public int id { get; set; }

        public string type_name { get; set; }

        public int members_min { get; set; }

        public int member_max { get; set; } 

        public ICollection<Group> Groups;
    }
}