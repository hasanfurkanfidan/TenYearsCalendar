using System;
using System.Collections.Generic;
using System.Text;
using TenYearsCalendar.Core.Entities.Abstract;

namespace TenYearsCalendar.Core.Entities.Concrete
{
    public class DaylyTodo:IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int DayId { get; set; }
        public Day Day { get; set; }
    }
}
