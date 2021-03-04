using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenYearsCalendar.Core.Dtos;

namespace TenYearsCalendar.Core.Validations
{
    public class RegisterValidationRule:AbstractValidator<AppUserRegisterDto>
    {
        public RegisterValidationRule()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez.");
            RuleFor(p => p.Lastname).NotEmpty().WithMessage("Soyad boş geçilemez");
            RuleFor(p => p.Email).NotEmpty().WithMessage("Email alanı boş geçilemez");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Parola alanı boş geçilemez");
            RuleFor(p => p.PasswordVerify).Equal(p => p.Password).WithMessage("Parolalar uyuşmuyor");
            RuleFor(p => p.Privacy).NotEmpty().WithMessage("Yasalar gereği sözleşmeyi okuyup onaylamanız gerekmektedir.");
        }
    }
}
