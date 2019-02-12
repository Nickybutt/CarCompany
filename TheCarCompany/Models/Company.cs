using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheCarCompany.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class Company
    {
        [Key]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Mission { get; set; }
        public string Strategy { get; set; }
        public string Vision { get; set; }
        public string Website { get; set; }
        public IList<Car> Cars { get; set; }
    }
}
