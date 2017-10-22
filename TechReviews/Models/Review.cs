using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TechReviews.Models
{
    public class Review
    {
        //Created a Primary Key to identify each record
        //Created the fields I wanted each review record to have
        //Formatted the date fields and set a range for the rating (should only be 1, 2, 3, 4 or 5)
        //Set the date review was created to automatically populate 
        //Created ForeignKey to access the Category model
        [Key]
        public int ID { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("Date Visited")]
        public DateTime DateVisited { get; set; }
        [Required(ErrorMessage = "A rating is required")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int Rating { get; set;  }
        private DateTime? dateCreated;
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("Date of Review")]
        public DateTime DateCreated
        {
            get { return dateCreated ?? DateTime.Now; }
            set { dateCreated = value; }
        }
        public string Content { get; set; }
        
        //Created ForeignKey to access the Category model
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        [DisplayName("Category")]
        public virtual Category Category { get; set; }

    }
}