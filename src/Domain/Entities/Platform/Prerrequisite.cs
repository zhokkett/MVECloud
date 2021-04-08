using System;
using System.Collections.Generic;

namespace MVECloud.Domain.Entities.Platform {
    public class Prerrequisite: AuditableEntity {
        public int id { get; set; }

        public int offer_id { get; set; }

        public int plan_id { get; set; }

        public Plan Plan { get; set; }

        public Offer Offer { get; set; }     
    }
}