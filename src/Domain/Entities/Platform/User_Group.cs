using System;
using System.Collections.Generic;

namespace MVECloud.Domain.Entities.Platform {

    public class User_Group: AuditableEntity {

        public int id {get;set;}
        public bool is_admin { get; set; }

        public int user_account_id { get; set; }
        
        public User_Account User {get;set;}

        public int group_id { get; set; }

        public Group Group;
    }
}