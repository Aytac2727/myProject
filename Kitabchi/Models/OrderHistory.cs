namespace Kitabchi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class OrderHistory
    {
        public int ID { get; set; }

        public int? OrderID { get; set; }

        public bool? OrderStatus { get; set; }

        [StringLength(500)]
        public string Note { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
