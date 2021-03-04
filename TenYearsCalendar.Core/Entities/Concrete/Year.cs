using System;
using System.Collections.Generic;
using System.Text;
using TenYearsCalendar.Core.Entities.Abstract;

namespace TenYearsCalendar.Core.Entities.Concrete
{
    public class Year:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Month> Months { get; set; }
        public List<YearlyTarget> YearlyTargets { get; set; }
        public List<YearAppUser> YearAppUsers { get; set; }
    }
}
