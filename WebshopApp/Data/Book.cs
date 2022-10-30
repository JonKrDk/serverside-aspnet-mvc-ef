﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebshopApp.Data
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [StringLength(20)]
        public string Author { get; set; }
        
        [Display(Name = "Number Of Pages")]
        [Range(1, 100, ErrorMessage = "Please enter a valid number of pages (1-100)")]
        public int NumberOfPages { get; set; }

        public string? Publisher { get; set; }
        public double Price { get; set; }
        public string ISBN { get; set; }
        public string Category { get; set; }

        [Display(Name = "Created Timestamp")]
        public DateTime Created { get; set; }
    }
}
