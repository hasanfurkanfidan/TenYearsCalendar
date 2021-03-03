using System;
using System.Collections.Generic;
using System.Text;
using TenYearsCalendar.Core.Entities.Abstract;

namespace TenYearsCalendar.Core.Entities.Concrete
{
    public class Day:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MonthId { get; set; }
        public List<DaylyTodo> DaylyTodos { get; set; }
        public Month Month { get; set; }
    }
}
