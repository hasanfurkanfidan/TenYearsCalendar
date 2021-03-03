using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenYearsCalendar.Core.Entities.Concrete;

namespace TenYearsCalendar.Core.DataAccess.EntityFrameworkCore
{
    public class Context:IdentityDbContext<AppUser,Role,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
        public DbSet<Day> Days { get; set; }
        public DbSet<DaylyTodo> DaylyTodos { get; set; }
        public DbSet<Month> Months { get; set; }
        public DbSet<Year> Years { get; set; }
        public DbSet<YearlyTarget> YearlyTargets { get; set; }
    }
}
