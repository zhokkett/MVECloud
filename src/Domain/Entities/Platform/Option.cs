using System;
using System.Collections.Generic;

namespace  MVECloud.Domain.Entities.Platform {
    public class Option: AuditableEntity {

        public Option ( ) {
            this.Plan_Options =  new ICollection<Plan_Option>();
        }

        public int id { get; set; }

        public string name { get; set; }

        public ICollection<Plan_Option> Plan_Options { get; set;};
    }
}