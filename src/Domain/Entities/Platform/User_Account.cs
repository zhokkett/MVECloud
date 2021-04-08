using System;
using System.Collections.Generic;

namespace MVECloud.Domain.Entities.Platform {

    public class User_Account: AuditableEntity {

        public void User_Account() {
            this.Users_In_Group = new ICollection<Users_In_Group>();
        }

        public int id { get; set; }

        public string first_name { get; set; }

        public string  last_name { get; set; }

        public string user_name { get; set; }

        public string password { get; set; }

        public string email { get; set; }   

        public string confirmation_code { get; set; }

        public string confirmation_time { get; set;}

        public ICollection<User_In_Group> Users_In_Group;
    }
}