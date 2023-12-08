using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Library.Pages
{
    public class ProductsModel : PageModel
    {
        private readonly LibraryContext _context;

        public ProductsModel(LibraryContext context)
        {
            _context = context;
        }
    }
}
