using System;

namespace  MVECloud.Domain.Entities.Platform {
    public class Option: AuditableEntity {
        public int id { get; set; }

        public string name { get; set; }

    }
}