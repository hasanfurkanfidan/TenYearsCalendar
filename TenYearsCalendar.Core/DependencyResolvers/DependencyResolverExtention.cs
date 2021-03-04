using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenYearsCalendar.Core.DataAccess.EntityFrameworkCore.Repositories;
using TenYearsCalendar.Core.DataAccess.Interfaces;

namespace TenYearsCalendar.Core.DependencyResolvers
{
    public static class DependencyResolverExtention
    {
        public static void SolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<IDaylyToDoRepository, EfDaylyTodoRepository>();
            services.AddScoped<IDayRepository, EfDayRepository>();
            services.AddScoped<IMonthRepository, EfMonthRepository>();
            services.AddScoped<IYearlyTargetRepository, EfYearlyTargetRepository>();
            services.AddScoped<IYearRepository, EfYearRepository>();
        }
    }
}
