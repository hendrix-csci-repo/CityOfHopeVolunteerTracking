﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using System.Linq;

namespace CityOfHopeVolunteerTracking.Models
{
    public class Volunteer
    {
        public int ID { get; set; }

        public string First { get; set; }
        public string Last { get; set; }
        public string Email { get; set; }
        public string Home { get; set; }
        public string Cell { get; set; }
        public string Type { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public Boolean Active { get; set; }
        public Boolean CommunityService { get; set; }
        public Boolean WorkersComp { get; set; }
        public Boolean Admin { get; set; }
        public ICollection<VolunteerActivity> volunteerActivities { get; set; }
    }
}