using System;
using System.Collections.Generic;

namespace MVECloud.Domain.Entities.Platform {

    public class User_Group_Type : AuditableEntity {
     
        public void User_Group_Type () {
            this.User_Groups =  new ICollection<Users_Groups>();
        }
        public int id { get; set; }

        public string type_name { get; set; }

        public int members_min { get; set; }

        public int members_max { get; set; } 

        public ICollection<User_Group> User_Groups;
    }
}