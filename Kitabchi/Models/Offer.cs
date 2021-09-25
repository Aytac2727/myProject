namespace Kitabchi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
 

    public partial class Offer
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Offer()
        //{
        //        OfferToImages = new HashSet<OfferToImage>();
        //}
        public int ID { get; set; }

        public int ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string Header { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public decimal TotalAmount { get; set; }

        public DateTime Time { get; set; }

        public virtual Product Product { get; set; }
        
        public virtual List<OfferToImage> OfferToImages { get; set; }
    }
}
