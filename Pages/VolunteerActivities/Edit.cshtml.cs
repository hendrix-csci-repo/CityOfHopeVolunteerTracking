﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoHO.Data;
using CoHO.Models;

namespace CoHO.Pages.VolunteerActivities
{
    public class EditModel : PageModel
    {
        private readonly CoHO.Data.ApplicationDbContext _context;

        public EditModel(CoHO.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public VolunteerActivity VolunteerActivity { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VolunteerActivity = await _context.VolunteerActivity
                .Include(v => v.Initiative)
                .Include(v => v.Volunteer).FirstOrDefaultAsync(m => m.ID == id);

            if (VolunteerActivity == null)
            {
                return NotFound();
            }
           ViewData["InitiativeId"] = new SelectList(_context.Initiative, "InitiativeID", "Description");
           ViewData["VolunteerId"] = new SelectList(_context.Volunteer, "VolunteerID", "First");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(VolunteerActivity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VolunteerActivityExists(VolunteerActivity.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool VolunteerActivityExists(int id)
        {
            return _context.VolunteerActivity.Any(e => e.ID == id);
        }
    }
}
