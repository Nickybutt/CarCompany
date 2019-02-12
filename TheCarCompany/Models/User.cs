using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheCarCompany.Models
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Scale { get; set; }
        public IList<Project> Projects { get; set; }
        public IList<Car> Cars { get; set; }


    }
}
