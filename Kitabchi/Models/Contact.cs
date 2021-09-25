namespace Kitabchi_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Contact
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        public int? PhoneNumber1 { get; set; }

        public int? PhoneNumber2 { get; set; }

        [StringLength(50)]
        public string SiteName { get; set; }
    }
}
