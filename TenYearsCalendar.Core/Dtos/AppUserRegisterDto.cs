using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenYearsCalendar.Core.Dtos
{
    public class AppUserRegisterDto
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public bool Privacy { get; set; }
        public string Password { get; set; }
        public string PasswordVerify { get; set; }
    }
}
