using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(13)]
        [MinLength(10)]
        public string ISBN { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        public string Title { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Genre { get; set; }
        [Required]
        [Display(Name = "Publish Date")]
        public DateTime PublishDate { get; set; }
        [Required]
        public int AuthorId { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}
