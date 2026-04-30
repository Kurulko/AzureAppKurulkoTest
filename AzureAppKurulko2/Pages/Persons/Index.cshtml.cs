using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AzureAppKurulko2.Data;

namespace AzureAppKurulko2.Pages_Persons
{
    public class IndexModel : PageModel
    {
        private readonly AzureAppKurulko2.Data.AppDbContext _context;

        public IndexModel(AzureAppKurulko2.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.Persons.ToListAsync();
        }
    }
}
