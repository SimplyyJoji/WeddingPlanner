using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
         [Key] // denotes PK, not needed if named ModelNameId
        public int WeddingId { get; set; }

        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "Name One ")]
        public string NameOne { get; set; }

        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "Name Two")]
        public string NameTwo { get; set; }

        [Required(ErrorMessage = "is required.")]
        [Display(Name = "Trip Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "Wedding Address")]
        public string Address { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        public List <Rsvp> Rsvps { get; set; }
        public int UserId { get; set; }
        public User CreatedBy { get; set; }
    }
    }
