namespace Kitabchi.Models
{
    using Kitabchi_Project.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    public partial class LanguageResource
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Key { get; set; }

        public int LanguageID { get; set; }

        [StringLength(10)]
        public string Value { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public virtual Language Language { get; set; }
    }
}
