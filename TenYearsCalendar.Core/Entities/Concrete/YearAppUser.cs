using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenYearsCalendar.Core.Entities.Abstract;

namespace TenYearsCalendar.Core.Entities.Concrete
{
    public class YearAppUser:IEntity
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int YearId { get; set; }
        public Year Year { get; set; }
    }
}
