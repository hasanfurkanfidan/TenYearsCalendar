using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenYearsCalendar.Core.Entities.Abstract;

namespace TenYearsCalendar.Core.Entities.Concrete
{
    public class AppUser:IdentityUser<int>,IEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public List<Day> Days { get; set; }
        public List<Month> Months { get; set; }
        public List<YearAppUser> YearAppUsers { get; set; }
    }
}
