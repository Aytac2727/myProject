namespace Kitabchi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
 

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int ID { get; set; }

        public DateTime PurchaseDate { get; set; }

        public string Status { get; set; }

        public int? OrderCode { get; set; }

        [StringLength(50)]
        public string PlacedOn { get; set; }

        [StringLength(50)]
        public string DeliveryChanges { get; set; }

        public decimal? TotalAmount { get; set; }

        public string CustomerID { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string CustomerEmail { get; set; }

        [StringLength(50)]
        public string CustomerPhone { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int? PromoID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public virtual Promo Promo { get; set; }
    }
}
