using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Journals
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Journal> Journal { get; set; }
        //Searching by Book
        [BindProperty(SupportsGet = true)]
        public string SearchVariable1 { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Book { get; set; }
        [BindProperty(SupportsGet = true)]
        public string JournalBook { get; set; }
        //Searching by Note keyword
        [BindProperty(SupportsGet = true)]
        public string SearchVariable2 { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Note { get; set; }
        [BindProperty(SupportsGet = true)]
        public string JournalNote { get; set; }
        public async Task OnGetAsync()
        {
            //searching by book
            IQueryable<string> bookQuery = from m in _context.Journal
                                           orderby m.Book
                                           select m.Book;

            string sortOrder;

            var journals = from m in _context.Journal
                           select m;
            if (!string.IsNullOrEmpty(SearchVariable1))
            {
                journals = journals.Where(s => s.Book.Contains(SearchVariable1));

            }
            if (!string.IsNullOrEmpty(SearchVariable2))
            {
                journals = journals.Where(s => s.Note.Contains(SearchVariable2));

            }
            if (!string.IsNullOrEmpty(JournalBook))
            {
                journals = journals.Where(x => x.Book == JournalBook);
            }
            Book = new SelectList(await bookQuery.Distinct().ToListAsync());
            Journal = await journals.ToListAsync();

    
        }

    }
}
    

