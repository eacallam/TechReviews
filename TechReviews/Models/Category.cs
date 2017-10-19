using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TechReviews.Models
{
    public class Category
    {
        //Created primary key and added System.ComponentModel.DataAnnotations
        //Created ICollection to have access to Review properties

        [Key] 
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}