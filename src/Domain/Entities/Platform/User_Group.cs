using System;
using System.Collections.Generic;

namespace MVECloud.Domain.Entities.Platform {

    public class User_Group: AuditableEntity {

        public void User_Group( ) {
            this.Users_In_Group =  new ICollection<Users_In_Group>();
        }

        public int id { get; set; }

        public int user_group_type_id { get; set; }

        public string customer_invoice_data { get; set; }

        public User_Group_Type User_Group_Type;

        public ICollection<User_In_Group> Users_In_Group;

    }
}