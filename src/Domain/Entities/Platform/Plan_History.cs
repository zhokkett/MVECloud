using System;
using System.Collections.Generic;

namespace MVECloud.Domain.Entities.Platform {

    public class Plan_History: Auditable_Entity {

        public void Plan_History () {
            this.Invoices =  new Icollection<Invoice>();
        }

        public int id { get; set; }

        public int subscription_id { get; set; }

        public int plan_id { get; set; }    

        public Datetime date_start { get; set; }

        public DateTime? date_end { get; set; }

        public Plan Plan {  get;    set;    }

        public Subscription Subscription { get; set;}

        public Icollection<Invoice> Invoices { get; set; }

    }

}