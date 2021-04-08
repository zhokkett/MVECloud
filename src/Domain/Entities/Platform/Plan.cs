using System;
using System.Collections.Generic;

namespace MVECloud.Domain.Entities.Platform {

    public class Plan : AuditableEntity {

        public void Plan ( ) {
            this.Plan_Options =  new ICollection<Plan_Option>();
        }

        public int id { get; set; }

        public string name { get; set; }

        public decimal current_price { get; set; }

        public bool is_active { get;set; }

        public Software Software { get; set; }

        public ICollection<Plan_Option> Plan_Options { get; set; }
    }
}