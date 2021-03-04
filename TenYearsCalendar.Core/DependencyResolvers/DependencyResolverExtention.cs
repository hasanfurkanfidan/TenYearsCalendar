using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenYearsCalendar.Core.DataAccess.EntityFrameworkCore;
using TenYearsCalendar.Core.DataAccess.EntityFrameworkCore.Repositories;
using TenYearsCalendar.Core.DataAccess.Interfaces;
using TenYearsCalendar.Core.Dtos;
using TenYearsCalendar.Core.Entities.Concrete;
using TenYearsCalendar.Core.Validations;

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


            services.AddTransient<IValidator<AppUserRegisterDto>, RegisterValidationRule>();
        }
    }
}
