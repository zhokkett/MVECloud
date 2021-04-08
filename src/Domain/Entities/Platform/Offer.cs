using System;
using System.Collections.Generic;

namespace MVECloud.Domain.Entities.Platform {

    public class Offer: AuditableEntity {

        public void Offer () {
            this.Includes =  new ICollection<Include>();
            this.Prerrequisites = new ICollection<Prerrequisite>();
        }
        
        public int id { get; set; }

        public string offer_name { get; set; }

        public DateTime offer_start_date { get; set; }

        public DateTime? offer_end_date {get;set;}

        public string description { get; set; }

        public decimal? discount_amount { get; set; }

        public decimal? discount_percentage { get; set; }

        public int? duration_months { get; set; }

        public Datetime? duration_end_date { get; set; }

        public ICollection<Include> Includes { get; set; }

        public ICollection<Prerrequisite> Prerrequisites { get; set;}

    }

}