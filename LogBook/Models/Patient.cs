using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LogBook.Models
{
    public class Patient
    {
        [Key]
        [StringLength(8, MinimumLength = 0)]
        public string HN { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }
        public Sex Sex { get; set; }
        public string Phone { get; set; }
        public ICollection<Visit> Visits { get; set; } = new HashSet<Visit>();

    }
}
