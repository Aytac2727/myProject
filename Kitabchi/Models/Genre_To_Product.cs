namespace Kitabchi_Project.Models
{
    using Kitabchi.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class Genre_To_Product
    {
        public int ID { get; set; }

        public int ProductID { get; set; }

        public int GenreID { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual Product Product { get; set; }
    }
}
