﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CityOfHopeVolunteerTracking.Data;
using CityOfHopeVolunteerTracking.Models;

namespace CityOfHopeVolunteerTracking.Pages.ValueOfHours
{
    public class DetailsModel : PageModel
    {
        private readonly CityOfHopeVolunteerTracking.Data.COHODatabaseContext _context;

        public DetailsModel(CityOfHopeVolunteerTracking.Data.COHODatabaseContext context)
        {
            _context = context;
        }

        public ValueOfHour ValueOfHour { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ValueOfHour = await _context.ValueOfHour.FirstOrDefaultAsync(m => m.ID == id);

            if (ValueOfHour == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
