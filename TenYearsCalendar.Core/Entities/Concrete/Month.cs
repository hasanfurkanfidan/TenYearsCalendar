﻿using System;
using System.Collections.Generic;
using System.Text;
using TenYearsCalendar.Core.Entities.Abstract;

namespace TenYearsCalendar.Core.Entities.Concrete
{
    public class Month:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearId { get; set; }
        public int AppUserId { get; set; }
        public Year Year { get; set; }
        public AppUser AppUser { get; set; }
        public List<Day> Days { get; set; }
    }
}
