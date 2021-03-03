using System;
using System.Collections.Generic;
using System.Text;
using TenYearsCalendar.Core.Entities.Abstract;

namespace TenYearsCalendar.Core.Entities.Concrete
{
    public class YearlyTarget:IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Year Year { get; set; }
        public bool IsCompleted { get; set; }
        public int YearId { get; set; }
    }
}
