using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lab4.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        [Required, StringLength(100), Display(Name ="Name")]
        public string ProductName { get; set; }

        [Required, StringLength(10000), Display(Name ="Product Description"),DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string ImagePath { get; set; }

        [Display(Name ="Price")]
        public double? UnitPrice { get; set; }
        
        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}