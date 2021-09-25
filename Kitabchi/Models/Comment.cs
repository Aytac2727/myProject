namespace Kitabchi.Models
{
    using Kitabchi.Models;
    using Kitabchi_Project.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
  

    public partial class Comment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comment()
        {
            CommentToProducts = new HashSet<CommentToProduct>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        public DateTime? TimeStamp { get; set; }

        [StringLength(500)]
        public string Text { get; set; }

        [StringLength(128)]
        public string UserID { get; set; }

        public int Rating { get; set; }

        public int LanguageID { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public virtual Language Language { get; set; }

        

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommentToProduct> CommentToProducts { get; set; }
    }
}
