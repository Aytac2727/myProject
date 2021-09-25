namespace Kitabchi.Models
{
    using Kitabchi_Project.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            CommentToProducts = new HashSet<CommentToProduct>();
            Genre_To_Product = new HashSet<Genre_To_Product>();
            Offers = new HashSet<Offer>();
            OrderItems = new HashSet<OrderItem>();
         
            Shop_To_Products = new HashSet<Shop_To_Products>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string AuthorName { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int? Discount { get; set; }

        public int? Barcode { get; set; }

        public bool IsActive { get; set; }

        public bool IsFeatured { get; set; }

        public bool IsDeleted { get; set; }

        public int CategoryID { get; set; }
        public int Rating { get; set; }

        [StringLength(500)]
        public string ImageUrl { get; set; }

        [StringLength(50)]
        public string publishing { get; set; }

        [StringLength(50)]
        public string Language { get; set; }

        [StringLength(500)]
        public string PdfLink { get; set; }

        public int? InStok { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommentToProduct> CommentToProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Genre_To_Product> Genre_To_Product { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Offer> Offers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }

       

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_To_Products> Shop_To_Products { get; set; }
    }
}
