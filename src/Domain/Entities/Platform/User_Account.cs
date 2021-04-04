using System;

namespace MVECloud.Domain.Entities.Platform {
    public class User_Account: AuditableEntity {
        public int id { get; set; }

        public string first_name { get; set; }

        public string  last_name { get; set; }

        public string user_name { get; set; }

        public string password { get; set; }

        public string email { get; set; }   

        public string confirmation_code { get; set; }

        public string confirmation_time { get; set;}
    }
}