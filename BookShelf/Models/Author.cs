using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [NotMapped]
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public string Penname { get; set; }
        [Display(Name ="Preferred Genre")]
        public string PreferredGenre { get; set; }
        public List<Book> Books { get; set; }
        public string ApplicationUserId { get; set; }
        [Display(Name ="Owner")]
        public ApplicationUser User { get; set; }
    }
}
