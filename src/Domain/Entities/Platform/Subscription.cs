using System;
using System.Collections.Generic;

namespace MVECloud.Domain.Entities.Platform {
    
    public class Subscription: AuditableEntity {

        public void Subscription () {
            this.Plan_History = new ICollection<Plan_History>();
        }

        public int id { get; set; }

        public int user_group_id { get; set; }

        public Datetime? trial_period_star_date { get; set; }

        public Datetime? trial_period_end_date { get; set; }

        public bool subscribe_after_trial { get; set; }

        public int current_plan_id { get; set; }

        public int offer_id { get; set; }

        public Datetime? offer_start_date { get; set; }

        public Datetime? offer_end_date { get; set; }

        public Datetime date_subscribed { get; set; }

        public Datetime valid_to { get; set; }

        public Datetime? date_unsubscribed { get; set; }

        public Plan Plan { get; set; }

        public User_Group User_Group { get; set; };

        public Offer Offer { get; set; }

        public Plan_History Plan_History { get; set; }

    }
}