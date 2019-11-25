using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models.ViewModels
{
    public class BookCreateViewModel
    {
        public string UserId { get; set; }
        public Book Book { get; set; }
        public int AuthorId { get; set; }
        public List<Author> Authors { get; set; } = new List<Author>();
        public List<SelectListItem> AuthorOptions
        {
            get
            {
                return Authors?.Select(a => new SelectListItem(a.FullName, a.Id.ToString())).ToList();
            }
        }
    }
}
