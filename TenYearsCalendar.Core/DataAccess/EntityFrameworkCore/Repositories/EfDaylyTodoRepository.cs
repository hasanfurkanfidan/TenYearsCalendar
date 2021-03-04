using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenYearsCalendar.Core.DataAccess.Interfaces;
using TenYearsCalendar.Core.Entities.Concrete;

namespace TenYearsCalendar.Core.DataAccess.EntityFrameworkCore.Repositories
{
    public class EfDaylyTodoRepository:EfEntityRepository<DaylyTodo>,IDaylyToDoRepository
    {
    }
}
