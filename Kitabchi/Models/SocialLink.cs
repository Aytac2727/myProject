namespace Kitabchi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    public partial class SocialLink
    {
        public int ID { get; set; }

        [Required]
        [StringLength(500)]
        public string LinkName { get; set; }

        [Required]
        [StringLength(500)]
        public string Socialİcon { get; set; }
    }
}
