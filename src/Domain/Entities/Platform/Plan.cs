using System;

namespace MVECloud.Domain.Entities.Platform {
    public class Plan : AuditableEntity {
        public int id { get; set; }

        public string name { get; set; }

        public decimal current_price { get; set; }

        public bool is_active { get;set; }

        public Software Software { get; set; }
    }
}