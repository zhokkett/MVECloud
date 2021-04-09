using System;
using System.Collections.Generic;

namespace MVECloud.Domain.Entities.Platform {

    public class Invoice: AuditableEntity {
        public int id { get; set; }

        public string customer_invoice_data { get; set; }

        public int subscription_id { get; set; }

        public int plan_history_id { get; set; }

        public Datetime invoice_period_start_date { get; set; }

        public Datetime invoice_period_end_date { get; set; }

        public string invoice_description { get; set; }

        public decimal invoice_amount { get; set; } 

        public Datetime? invoice_due { get; set; }

        public DateTime? invoice_paid { get; set; }

        public Subscription Subscription { get; set; }

        public Plan_History Plan_History { get; set; }

    }

}