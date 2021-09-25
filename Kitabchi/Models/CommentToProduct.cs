namespace Kitabchi_Project.Models
{
    using Kitabchi.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
  

    public partial class CommentToProduct
    {
        public int ID { get; set; }

        public int CommentID { get; set; }

        public int ProductID { get; set; }

        public virtual Comment Comment { get; set; }

        public virtual Product Product { get; set; }
    }
}
