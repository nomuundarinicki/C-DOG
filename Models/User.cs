using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dog.Models
{
    public class User : BaseEntity 
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string PW { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<Part> People { get; set; }
        public List<Activity> Activity { get; set; }
        public User()
        {
            People = new List<Part>();
            Activity = new List<Activity>();
        }

    }
}