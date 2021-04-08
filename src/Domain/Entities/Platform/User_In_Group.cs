using System;

namespace MVECloud.Domain.Entities.Platform {

    public class User_In_Group: AuditableEntity {
        public int id { get; set; }

        public int user_group_id { get; set; }

        public int user_account_id { get; set; }

        public bool group_admin { get; set; }

        public User_Group User_Group { get; set; }

        public User_Account User_Account { get; set; }

    }
}