using System;

namespace MVECloud.Domain.Entities.Restaurant {
    public class User: AuditableEntity {
        public int id { get; set; }

        public string first_name { get; set; }   

        public string last_name { get; set; }

        public string login    {get;set;}

        public string password {get;set;}

        public string email { get; set; }
        public int user_type_id  {get;set;}
        public User_Type Type { get; set;}
    }
}