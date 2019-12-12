﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoHO.Data;
using CoHO.Models;

namespace CoHO.Pages.Races
{
    public class IndexModel : PageModel
    {
        private readonly CoHO.Data.ApplicationDbContext _context;

        public IndexModel(CoHO.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Race> Race { get;set; }

        public async Task OnGetAsync()
        {
            IQueryable<Race> RaceIQueryable = from r in _context.Race select r;
            RaceIQueryable = RaceIQueryable.OrderBy(r => r.Description);
            Race = await RaceIQueryable.ToListAsync();
        }
    }
}
